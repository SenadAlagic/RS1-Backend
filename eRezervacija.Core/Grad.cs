using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
	public class Grad
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string PostanskiBroj { get; set; }
		[ForeignKey("DrzavaID")]
		public Drzava drzava { get; set; }
		public int DrzavaID;
		public byte[]? slika { get; set; }
		public int BrojHotelaUGradu { get; set; }
	}
}
