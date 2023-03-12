using System;
using eRezervacija.Core;

namespace eRezervacija.API.ViewModels
{
	public class GradVM
	{
		public string Name { get; set; }
		public string postanskiBroj { get; set; }
        public int drzavaID { get; set; }
        public string slika { get; set; }
		public string BrojHotelaUGradu { get; set; }
    }
}

