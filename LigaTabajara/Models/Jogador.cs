using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace LigaTabajara.Models
{
	public enum Posicao { Goleiro, Zagueiro, Volante, Meia, Atacante, LateralDireta, LateralEsquerda }
	public enum PePreferido { Esquerdo, Direito, Ambidestro}
	public class Jogador
	{
		public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Data de Nacimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
		public string Nacionalidade { get; set; }
		public Posicao Posicao { get; set; }

        [Display(Name = "Número da Camisa")]
        public int NumCamisa { get; set; }

        [Display(Name = "Altura (m)")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public float Altura { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "Peso (kg)")]
        public float Peso { get; set; }

        [Display(Name = "Pé preferido")]

        public PePreferido PePreferido { get; set; }

        public int TimeId { get; set; }
        public virtual Time Time { get; set; }
    }
}