using LigaTabajara.DAL;
using LigaTabajara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LigaTabajara.Controllers
{
    public class HomeController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        public ActionResult Index()
        {
            // Busca todos os times
            var teams = db.Times.ToList();
            var teamStats = new List<TeamStatViewModel>();

            foreach (var t in teams)
            {
                // Partidas com resultados (jogo concluído)
                var homeMatches = db.Partidas.Where(p => p.TimeMandanteId == t.Id &&
                                                         p.GolsMandante.HasValue && p.GolsVisitante.HasValue);
                var awayMatches = db.Partidas.Where(p => p.TimeVisitanteId == t.Id &&
                                                         p.GolsMandante.HasValue && p.GolsVisitante.HasValue);

                int points = 0;
                int goalsScored = 0;
                int goalsConceded = 0;

                foreach (var match in homeMatches)
                {
                    int gm = match.GolsMandante.Value;
                    int gv = match.GolsVisitante.Value;
                    goalsScored += gm;
                    goalsConceded += gv;
                    if (gm > gv)
                        points += 3;
                    else if (gm == gv)
                        points += 1;
                }
                foreach (var match in awayMatches)
                {
                    int gm = match.GolsVisitante.Value;
                    int gv = match.GolsMandante.Value;
                    goalsScored += gm;
                    goalsConceded += gv;
                    if (gm > gv)
                        points += 3;
                    else if (gm == gv)
                        points += 1;
                }
                int goalDifference = goalsScored - goalsConceded;

                // Verifica se o time está apto:
                bool hasMinPlayers = db.Jogadores.Count(j => j.TimeId == t.Id) >= 30;
                var comissao = db.ComissoesTecnicas.Where(c => c.TimeId == t.Id).ToList();
                bool hasMinComissao = comissao.Count >= 5 && comissao.GroupBy(c => c.Cargo).All(g => g.Count() == 1);
                bool isApto = hasMinPlayers && hasMinComissao;

                teamStats.Add(new TeamStatViewModel
                {
                    Time = t,
                    Points = points,
                    GoalDifference = goalDifference,
                    IsApto = isApto
                });
            }

            // Agenda de partidas: buscamos todas as partidas (ordena por data)
            var schedule = db.Partidas.Include("TimeMandante").Include("TimeVisitante")
                              .OrderBy(p => p.DataPartida).ToList();

            var model = new HomeIndexViewModel
            {
                TeamStats = teamStats.OrderByDescending(s => s.Points)
                                     .ThenByDescending(s => s.GoalDifference).ToList(),
                Schedule = schedule
            };
            return View(model);
        }
    }

    // ViewModel para estatísticas dos times
    public class TeamStatViewModel
    {
        public Time Time { get; set; }
        public int Points { get; set; }
        public int GoalDifference { get; set; }
        public bool IsApto { get; set; }
    }

    // ViewModel para a Home com classificação e agenda de partidas
    public class HomeIndexViewModel
    {
        public List<TeamStatViewModel> TeamStats { get; set; }
        public List<Partida> Schedule { get; set; }
    }
}