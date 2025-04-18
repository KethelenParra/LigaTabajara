using LigaTabajara.DAL;
using LigaTabajara.Models;
using LigaTabajara.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace LigaTabajara.Controllers
{
    public class HomeController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        public ActionResult Index(int? round)
        {
            // 1) Lista de todas as rodadas existentes
            var allRounds = db.Partidas
                              .Select(p => p.Round)
                              .Distinct()
                              .OrderBy(r => r)
                              .ToList();

            // 2) Carrega todas as partidas com mandante/visitante
            var partidas = db.Partidas
                             .Include(p => p.TimeMandante)
                             .Include(p => p.TimeVisitante)
                             .OrderBy(p => p.DataPartida)
                             .ToList();

            // 3) Agenda filtrada pela rodada (se houver)
            var schedule = round.HasValue
                ? partidas.Where(p => p.Round == round.Value).ToList()
                : partidas;

            // 4) Só partidas já jogadas
            var completed = partidas
                .Where(p => p.GolsMandante.HasValue && p.GolsVisitante.HasValue)
                .ToList();

            // 5) Estatísticas por time
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

                // aptidão
                bool hasMinPlayers = db.Jogadores.Count(j => j.TimeId == t.Id) >= 30;
                var comissao = db.ComissoesTecnicas.Where(c => c.TimeId == t.Id).ToList();
                bool hasMinComissao = comissao.Count >= 6
                                     && comissao.GroupBy(c => c.Cargo).All(g => g.Count() == 1);
                bool isApto = hasMinPlayers && hasMinComissao;

                // últimos 5 resultados
                var recentMatches = completed
                    .Where(p => p.TimeMandanteId == t.Id || p.TimeVisitanteId == t.Id)
                    .OrderByDescending(p => p.DataPartida)
                    .Take(5)
                    .ToList();

                var last5 = new List<ResultadoEnum>();
                foreach (var p in recentMatches)
                {
                    bool isHome = p.TimeMandanteId == t.Id;
                    int teamGoals = isHome ? p.GolsMandante.Value : p.GolsVisitante.Value;
                    int oppGoals = isHome ? p.GolsVisitante.Value : p.GolsMandante.Value;

                    if (teamGoals > oppGoals) last5.Add(ResultadoEnum.Vitoria);
                    else if (teamGoals < oppGoals) last5.Add(ResultadoEnum.Derrota);
                    else last5.Add(ResultadoEnum.Empate);
                }

                return new TeamStatView
                {
                    Time = t,
                    Games = games,
                    Wins = wins,
                    Draws = draws,
                    Losses = losses,
                    Points = points,
                    GoalDifference = goalDifference,
                    IsApto = isApto,
                    Last5Results = last5
                };
            })
            .OrderByDescending(vm => vm.Points)
            .ThenByDescending(vm => vm.GoalDifference)
            .ToList();

            // 6) Campeonato concluído?
            bool todasRodadas = allRounds.Count == 38;
            bool todosJogosLancados = completed.Count == partidas.Count;
            bool encerrado = todasRodadas && todosJogosLancados;

            // 7) Campeão
            var campeao = encerrado && teamStats.Any()
                         ? teamStats.First()
                         : null;

            // 8) Artilheiro geral
            var top = db.EstatisticasJogos
                        .Include(e => e.Jogador)
                        .GroupBy(e => e.Jogador)
                        .Select(g => new { Jog = g.Key, Gols = g.Sum(x => x.Gols) })
                        .OrderByDescending(x => x.Gols)
                        .FirstOrDefault();

            PlayerGoalView topScorer = top == null
                ? null
                : new PlayerGoalView
                {
                    JogadorNome = top.Jog.Name,
                    TotalGols = top.Gols
                };

            // ——— NOVO RESUMO ———
            int totalMatches = partidas.Count;
            int totalGoals = completed.Sum(p => p.GolsMandante.Value + p.GolsVisitante.Value);
            double avgGoals = totalMatches > 0
                              ? Math.Round((double)totalGoals / totalMatches, 2)
                              : 0;

            var mostWins = teamStats.OrderByDescending(t => t.Wins).FirstOrDefault();
            var mostDraws = teamStats.OrderByDescending(t => t.Draws).FirstOrDefault();
            var mostLoss = teamStats.OrderByDescending(t => t.Losses).FirstOrDefault();

            // 9) ViewModel final
            var model = new HomeIndexView
            {
                TeamStats = teamStats,
                Rounds = allRounds,
                Round = round,
                Schedule = schedule,
                CampeonatoConcluido = encerrado,
                Campeao = campeao,
                TopScorer = topScorer,

                // Novas propriedades — não esqueça de incluí‑las em HomeIndexViewModel!
                TotalRounds = allRounds.Count,
                TotalMatches = totalMatches,
                TotalGoals = totalGoals,
                GoalsPerMatch = avgGoals,
                MostWins = mostWins,
                MostDraws = mostDraws,
                MostLosses = mostLoss
            };

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}