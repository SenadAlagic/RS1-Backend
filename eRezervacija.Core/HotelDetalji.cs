using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class HotelDetalji
	{
		[Key]
		public int Id { get; set; }
		public bool KonferencijskaSala { get; set; }
		public bool Bazen { get; set; }
		public bool Spa { get; set; }
		public bool Sauna { get; set; }
		public bool Teretana { get; set; }
		public bool Restoran { get; set; }
		public bool Kafic { get; set; }
	}
}
