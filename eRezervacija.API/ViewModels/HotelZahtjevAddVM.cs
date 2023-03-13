namespace eRezervacija.API.ViewModels
{
	public class HotelZahtjevAddVM
	{
		public string Naziv { get; set; }
		public string Opis { get; set; }
		public string Adresa { get; set; }
		public string Vlasnik { get; set; }
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
