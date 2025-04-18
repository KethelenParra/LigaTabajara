using LigaTabajara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LigaTabajara.ViewModels
{
	public class PartidaIndexView
	{
        public List<Partida> Schedule { get; set; }
        public List<int> Rounds { get; set; }
        public int? Round { get; set; }

        // filtros
        public string SearchJogo { get; set; }
        public string SelectedEstadio { get; set; }

        // lista de estádios (para o dropdown)
        public IEnumerable<SelectListItem> EstadioOptions { get; set; }
    }
}