using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LigaTabajara.Models
{
    public enum StatusTime { Apto, NaoApto }
	public class Time
	{
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        [Display(Name = "Data da Fundação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}",
        ApplyFormatInEditMode = true)]
        public DateTime DataFundacao { get; set; }
        public string Estadio { get; set; }
        public int CapacidadeEstadio { get; set; }
        public string CorUniformePrimario { get; set; }
        public string CorUniformeSecuntario { get; set; }
        public StatusTime? StatusTime { get; set; }

    }
}