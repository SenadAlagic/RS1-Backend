using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eRezervacija.Core.Autentikacija
{
	public class AutentifikacijaToken
	{
		[Key]
		public int Id { get; set; }
		public string Vrijednost { get; set; }
		[NotMapped]
		public Gost? gost { get; set; }
		[NotMapped]
		public Admin? admin { get; set; }
		[NotMapped]
		public Vlasnik? vlasnik { get; set; }

		[ForeignKey("KorisnikID")]
		public Korisnik korisnik { get; set; }
		public int KorisnikID { get; set; }
		
		//public DateTime VrijemeEvidentiranja { get; set; }
		public string? ipAdresa { get; set; }
	}
}
