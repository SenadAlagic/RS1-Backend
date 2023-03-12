using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class SobaDetalji
	{
		[Key]
		public int Id { get; set; }
		public bool Tv { get; set; }
		public bool WiFi { get; set; }
		public bool Kuhinja { get; set; }
		public bool DozvoljenoPusenje { get; set; }
		public bool KucniLjubimci { get; set; }
		public bool PrilagodjenoZaDjecu { get; set; }
		public bool Fen { get; set; }
		public bool Pegla { get; set; }
		public bool DodatniJastuci { get; set; }
		public bool Mikrovalna { get; set; }
		public bool KafeAparat { get; set; }
		public bool Kuhalo { get; set; }
		public bool OcistitiPrijeOdlaska { get; set; }
		public bool Kupatilo { get; set; }
		public bool Klima { get; set; }
		public bool Grijanje { get; set; }
		public bool Balkon { get; set; }
		//public bool Dorucak { get; set; } je li ovo u sklopu sobe ili hotela?
	}
}
