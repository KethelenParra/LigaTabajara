using LigaTabajara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LigaTabajara.ViewModels
{
	public class ComissaoTecnicaIndexViewModel
	{
        public IEnumerable<ComissaoTecnica> Membros { get; set; }

        // filtros
        public string SearchName { get; set; }
        public Cargo? SelectedCargo { get; set; }

        // lista para popular dropdown
        public IEnumerable<SelectListItem> Cargos { get; set; }
    }
}