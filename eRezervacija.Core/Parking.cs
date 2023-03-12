using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Parking
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("HotelID")]
		public Hotel hotel { get; set; }
		public int HotelID { get; set; }
		public string Naziv { get; set; }
		public string Adresa { get; set; }
	}
}
