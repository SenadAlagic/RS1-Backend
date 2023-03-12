using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Admin
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("KorisnikID")]
		public Korisnik korisnik { get; set; }
		public int KorisnikID { get; set; }
	}
}
