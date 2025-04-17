using LigaTabajara.DAL;
using LigaTabajara.Models;
using LigaTabajara.ViewModels;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using System.Data.Entity;

namespace LigaTabajara.Controllers
{
    public class HomeController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        public ActionResult Index(int? round)
        {
            // 1) Lista de todas as rodadas existentes, em ordem
            var allRounds = db.Partidas
                              .Select(p => p.Round)
                              .Distinct()
                              .OrderBy(r => r)
                              .ToList();

            // 2) Carrega todas as partidas com mandante/visitante incluídos
            var partidas = db.Partidas
                             .Include(p => p.TimeMandante)
                             .Include(p => p.TimeVisitante)
                             .OrderBy(p => p.DataPartida)
                             .ToList();

            // 3) Agenda filtrada pela rodada, se houver
            var schedule = round.HasValue
                ? partidas.Where(p => p.Round == round.Value).ToList()
                : partidas;

            // 4) Apenas partidas já jogadas, para cálculo de estatísticas
            var completed = partidas
                .Where(p => p.GolsMandante.HasValue && p.GolsVisitante.HasValue)
                .ToList();

            // 5) Monta as estatísticas de cada time (agora usando 'completed')
            var teams = db.Times.ToList();
            var teamStats = teams.Select(t =>
            {
                var home = completed.Where(p => p.TimeMandanteId == t.Id);
                var away = completed.Where(p => p.TimeVisitanteId == t.Id);

                int games = home.Count() + away.Count();
                int wins = home.Count(p => p.GolsMandante > p.GolsVisitante)
                          + away.Count(p => p.GolsVisitante > p.GolsMandante);
                int draws = completed.Count(p =>
                                (p.TimeMandanteId == t.Id || p.TimeVisitanteId == t.Id)
                                 && p.GolsMandante == p.GolsVisitante);
                int losses = games - wins - draws;

                int goalsFor = home.Sum(p => p.GolsMandante.Value)
                                    + away.Sum(p => p.GolsVisitante.Value);
                int goalsAgainst = home.Sum(p => p.GolsVisitante.Value)
                                    + away.Sum(p => p.GolsMandante.Value);

                int points = wins * 3 + draws;
                int goalDifference = goalsFor - goalsAgainst;

                bool hasMinPlayers = db.Jogadores.Count(j => j.TimeId == t.Id) >= 30;
                var comissao = db.ComissoesTecnicas.Where(c => c.TimeId == t.Id).ToList();
                bool hasMinComissao = comissao.Count >= 5
                                      && comissao.GroupBy(c => c.Cargo).All(g => g.Count() == 1);
                bool isApto = hasMinPlayers && hasMinComissao;

                return new TeamStatView
                {
                    Time = t,
                    Games = games,
                    Wins = wins,
                    Draws = draws,
                    Losses = losses,
                    Points = points,
                    GoalDifference = goalDifference,
                    IsApto = isApto
                };
            })
            .OrderByDescending(vm => vm.Points)
            .ThenByDescending(vm => vm.GoalDifference)
            .ToList();

            // 6) Prepara o ViewModel
            var model = new HomeIndexView
            {
                TeamStats = teamStats,
                Rounds = allRounds,
                Round = round,
                Schedule = schedule
            };

            return View(model);
        }
    }
}
