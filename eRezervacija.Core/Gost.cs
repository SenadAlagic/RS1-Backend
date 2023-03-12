using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace eRezervacija.Core
{
	public class Gost
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("KorisnikID")]
		public Korisnik korisnik { get; set; }
		public int KorisnikID { get; set; }

		[ForeignKey("KreditnaKarticaID")]
		public KreditnaKartica kartica { get; set; }
		public int KreditnaKarticaID { get; set; }
	}
}
