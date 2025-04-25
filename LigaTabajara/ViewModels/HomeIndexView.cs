using LigaTabajara.Controllers;
using LigaTabajara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LigaTabajara.ViewModels
{
    public class HomeIndexView
    {
        public List<TeamStatView> TeamStats { get; set; }
        public List<Partida> Schedule { get; set; }

        public List<int> Rounds { get; set; }
        public int? Round { get; set; }

        public bool CampeonatoConcluido { get; set; }
        public TeamStatView Campeao { get; set; }
        public PlayerGoalView TopScorer { get; set; }
        public int TotalRounds { get; set; }
        public int TotalMatches { get; set; }
        public int TotalGoals { get; set; }
        public double GoalsPerMatch { get; set; }

        public TeamStatView MostWins { get; set; }
        public TeamStatView MostDraws { get; set; }
        public TeamStatView MostLosses { get; set; }

        public bool LeagueIsApto { get; set; }
    }

    public class PlayerGoalView
    {
        public string JogadorNome { get; set; }
        public int TotalGols { get; set; }
    }
}