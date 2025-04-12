using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LigaTabajara.Models
{
	public class EstatisticaJogo
	{
        public int Id { get; set; }

        [Display(Name = "Partida")]
        public int PartidaId { get; set; }
        public virtual Partida Partida { get; set; }

        [Display(Name = "Jogador")]
        public int JogadorId { get; set; }
        public virtual Jogador Jogador { get; set; }

        [Display(Name = "Gols")]
        public int Gols { get; set; }
    }
}