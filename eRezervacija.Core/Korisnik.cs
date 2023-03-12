using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Korisnik
	{
		[Key]
		public int Id { get; set; }
		public string Uloga{ get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Spol { get; set; }
		public DateTime Datum_rodjenja { get; set; }
		public string Email { get; set; }
		public string Broj_telefona{ get; set; }
		public string Username{ get; set; }
		[JsonIgnore]
		public string Password{ get; set; }
		public DateTime DatumKreiranja { get; set; }
		public DateTime DatumPromjene { get; set; }
	}
}
