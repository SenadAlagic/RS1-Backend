using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Soba
	{
		[Key]
		public int Id { get; set; }
		public string Opis { get; set; }
		[ForeignKey("HotelID")]
		public Hotel hotel { get; set; }
		public int HotelID { get; set; }
		[ForeignKey("SobaDetaljiID")]
		public SobaDetalji sobaDetalji { get; set; }
		public int SobaDetaljiID { get; set; }
		public int Kapacitet { get; set; }
		public int Sprat { get; set; }
		public int BrojKreveta { get; set; }
		public int BrojKrevetaZaJednuOsobu { get; set; }
		public int BrojKrevetaNaSprat { get; set; }
		public int BrojBracnihKreveta { get; set; }
		public bool MogucnostDodavanjaDjecijegKreveta { get; set; }
		public float UkupnaCijena { get; set; }
	}
}
