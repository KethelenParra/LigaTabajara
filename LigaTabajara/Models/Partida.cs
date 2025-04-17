using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace LigaTabajara.Models
{
	public class Partida
	{
		public int Id { get; set; }

        [Display(Name = "Rodada")]
        public int Round { get; set; }

        [Display(Name = "Data da Partida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataPartida { get; set; }

        [Display(Name = "Time Mandante")]
        public int TimeMandanteId { get; set; }
        public virtual Time TimeMandante { get; set; }

        [Display(Name = "Time Visitante")]
        public int TimeVisitanteId { get; set; }
        public virtual Time TimeVisitante { get; set; }

        [Display(Name = "Gols Mandante")]
        public int? GolsMandante { get; set; }

        [Display(Name = "Gols Visitante")]
        public int? GolsVisitante { get; set; }

        public virtual ICollection<EstatisticaJogo> EstatisticasJogos { get; set; } = new List<EstatisticaJogo>();
    }
}