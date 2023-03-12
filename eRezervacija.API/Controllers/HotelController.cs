using System;
using Microsoft.AspNetCore.Mvc;
using eRezervacija.API.Helpers;
using eRezervacija.API.ViewModels;
using eRezervacija.Core;
using eRezervacija.Service;
using Microsoft.AspNetCore.Http;
using eRezervacija.Repository;
using eRezervacija.Core.Autentikacija;

namespace eRezervacija.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        IHotelService hotelService;
        IHotelDetaljiService hotelDetaljiService;
        IGradService gradService;

        public HotelController(IHotelService hotelService, IHotelDetaljiService hotelDetaljiService, IGradService gradService)
        {
            this.hotelService = hotelService;
            this.hotelDetaljiService = hotelDetaljiService;
            this.gradService = gradService;
        }

        [HttpPost]
        //[Autorizacija(Admin: true, Vlasnik: true, Gost: false)]
        public Hotel AddHotel(HotelVM hotel)
        {
            var noviHotel = new Hotel()
            {
                Naziv = hotel.Naziv,
                Opis = hotel.Opis,
                Adresa = hotel.Adresa,
                VlasnikID = hotel.VlasnikID,
                HotelDetaljiID = hotel.HotelDetaljiID,
                EmailHotela = hotel.EmailHotela,
                BrojTelefona = hotel.BrojTelefona,
                GradID = hotel.GradID,
                UkupanBrojSoba = hotel.UkupanBrojSoba,
                BrojJednokrevetnihSoba = hotel.BrojJednokrevetnihSoba,
                BrojDvokrevetnihSoba = hotel.BrojDvokrevetnihSoba,
                BrojTrokrevetnihSoba = hotel.BrojTrokrevetnihSoba,
                BrojSpratova = hotel.BrojSpratova,
                VrijemeCheckIna = hotel.VrijemeCheckIna,
                VrijemeCheckOuta = hotel.VrijemeCheckOuta
            };
            gradService.DodajHotelUGradu(hotel.GradID);
            hotelService.Add(noviHotel);
            return noviHotel;
        }

        [HttpGet]
        //[Autorizacija(Admin: true, Vlasnik: true, Gost: true)]
        public IEnumerable<Hotel> GetAllHotels()
        {
            return hotelService.GetAll();
        }

        [HttpPost]
        //[Autorizacija(Admin: true, Vlasnik: true, Gost: false)]
        public HotelDetalji AddHotelDetalji(HotelDetaljiVM hotelDetalji)
        {
            var noviHotelDetalji = new HotelDetalji()
            {
                KonferencijskaSala = hotelDetalji.KonferencijskaSala,
                Bazen = hotelDetalji.Bazen,
                Spa = hotelDetalji.Spa,
                Sauna = hotelDetalji.Sauna,
                Teretana = hotelDetalji.Teretana,
                Restoran = hotelDetalji.Restoran,
                Kafic = hotelDetalji.Kafic
            };
            hotelDetaljiService.Add(noviHotelDetalji);
            return noviHotelDetalji;
        }

    }
}

