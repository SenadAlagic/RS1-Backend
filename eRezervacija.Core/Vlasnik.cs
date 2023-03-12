using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Vlasnik
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("KorisnikID")]
		public Korisnik korisnik { get; set; }
		public int KorisnikID { get; set; }
		public string BrojBankovnogRacuna { get; set; }
		public string BrojLicneKarte { get; set; }
		//public byte[] VlasnickiList { get; set; }
	}
}
