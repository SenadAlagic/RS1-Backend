using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Slika
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("SobaID")]
		public Soba soba { get; set; }
		public int SobaID { get; set; }
		public byte[] SlikaByteArray { get; set; }
		public string Opis { get; set; }
	}
}
