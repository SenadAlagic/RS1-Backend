namespace eRezervacija.API.ViewModels
{
	public class RegistracijaGostVM
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }
		public DateTime DatumRodjenja { get; set; }
		public string Spol { get; set; }
		public string BrojTelefona { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
