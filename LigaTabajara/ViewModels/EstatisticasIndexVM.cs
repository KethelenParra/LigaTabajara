using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LigaTabajara.ViewModels
{
	public class EstatisticasIndexVM
	{
        public int? Rodada { get; set; }
        public List<ArtilheiroVM> Artilheiros { get; set; }
        public List<TimeGolsVM> TimeGols { get; set; }
    }
}