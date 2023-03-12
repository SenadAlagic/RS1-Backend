using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eRezervacija.Core;

namespace eRezervacija.API.ViewModels
{
	public class HotelVM
	{
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public int VlasnikID { get; set; }
        public int HotelDetaljiID { get; set; }
        public string EmailHotela { get; set; }
        public string BrojTelefona { get; set; }
        public int GradID { get; set; }
        public int UkupanBrojSoba { get; set; }
        public int BrojJednokrevetnihSoba { get; set; }
        public int BrojDvokrevetnihSoba { get; set; }
        public int BrojTrokrevetnihSoba { get; set; }
        public int BrojSpratova { get; set; }
        public string VrijemeCheckIna { get; set; }
        public string VrijemeCheckOuta { get; set; }
    }
}

