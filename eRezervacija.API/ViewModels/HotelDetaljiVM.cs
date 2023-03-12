using System;
namespace eRezervacija.API.ViewModels
{
	public class HotelDetaljiVM
	{
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

