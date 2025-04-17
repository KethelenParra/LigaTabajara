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
    }
}