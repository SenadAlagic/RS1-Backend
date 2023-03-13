using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class HotelZahtjev
	{
		[Key]
		public int Id { get; set; }
		public string Naziv { get; set; }
		public string Opis { get; set; }
		public string Adresa { get; set; }
		public string vlasnik { get; set; }
		public string EmailHotela { get; set; }
		public string BrojTelefona { get; set; }
		public string Grad { get; set; }
		public int UkupanBrojSoba { get; set; }
		public int BrojJednokrevetnihSoba { get; set; }
		public int BrojDvokrevetnihSoba { get; set; }
		public int BrojTrokrevetnihSoba { get; set; }
		public int BrojSpratova { get; set; }
		public string VrijemeCheckIna { get; set; }
		public string VrijemeCheckOuta { get; set; }
	}
}
