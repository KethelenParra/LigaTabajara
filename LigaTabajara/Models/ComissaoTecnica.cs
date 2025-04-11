using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LigaTabajara.Models
{
	public enum Cargo { Treinador, Auxiliar, PreparadorFisico, TreinadorGoleiro, Fisiologista, Fisioterapeuta }
    public class ComissaoTecnica
	{
		public int Id { get; set; }
        public string Nome { get; set; }
        public Cargo Cargo { get; set; }
        [Display(Name = "Data de Nacimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        public ICollection<Time> Time { get; set; } = new List<Time>();
    }
}