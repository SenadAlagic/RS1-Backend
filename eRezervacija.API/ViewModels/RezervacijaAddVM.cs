namespace eRezervacija.API.ViewModels
{
    public class RezervacijaAddVM
    {
        public int GostId { get; set; }
        public int SobaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumCheckIn { get; set; }
        public DateTime DatumCheckOut { get; set; }
        public int BrojGostiju { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public string NacinPlacanja { get; set; }
        public double Cijena { get; set; }
    }
}
