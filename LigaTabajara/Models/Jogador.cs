using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace LigaTabajara.Models
{
	public enum Posicao { Goleiro, Zagueiro, Volante, Meia, Atacante, LateralDireta, LateralEsquerda }
	public enum PePreferido { Esquerdo, Direito}
	public class Jogador
	{
		public int ID { get; set; }
		public string Name { get; set; }

        [Display(Name = "Data de Nacimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public string DataNascimento { get; set; }
		public string Nacionalidade { get; set; }
		public Posicao Posicao { get; set; }

        [Display(Name = "Número da Camisa")]
        public int NumCamisa { get; set; }
		public float Altura { get; set; }
		public float Peso { get; set; }

        [Display(Name = "Pé preferido")]

        public PePreferido PePreferido { get; set; }

        public ICollection<Time> Time { get; set; } = new List<Time>();
    }
}