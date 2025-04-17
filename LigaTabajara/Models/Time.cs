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
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }

        [Display(Name = "Data da Fundação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DataFundacao { get; set; }
        [Required]
        public string Estadio { get; set; }
        public int CapacidadeEstadio { get; set; }
        [Display(Name = "Cor Uniforme Primário")]
        public string CorUniformePrimario { get; set; }
        [Display(Name = "Cor Uniforme Secundário")]
        public string CorUniformeSecuntario { get; set; }
        public StatusTime? StatusTime { get; set; }

        public virtual ICollection<Jogador> Jogadores { get; set; } = new List<Jogador>();
        public virtual ICollection<ComissaoTecnica> ComissoesTecnicas { get; set; } = new List<ComissaoTecnica>();
        public virtual ICollection<Partida> PartidasMandantes { get; set; } = new List<Partida>();
        public virtual ICollection<Partida> PartidasVisitantes { get; set; } = new List<Partida>();
    }
}