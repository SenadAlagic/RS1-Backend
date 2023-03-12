using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class ParkingMjesto
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("ParkingID")]
		public Parking parking { get; set; }
		public int ParkingID { get; set; }
		public string Naziv { get; set; }
		public int Sprat { get; set; }
	}
}
