using LigaTabajara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LigaTabajara.ViewModels
{
	public class JogadorIndexViewModel
	{
        public IEnumerable<Jogador> Jogadores { get; set; }

        // filtros
        public string SearchName { get; set; }
        public Posicao? SelectedPosicao { get; set; }
        public PePreferido? SelectedPe { get; set; }

        // listas para popular dropdowns
        public IEnumerable<SelectListItem> Posicoes { get; set; }
        public IEnumerable<SelectListItem> Pes { get; set; }
    }
}