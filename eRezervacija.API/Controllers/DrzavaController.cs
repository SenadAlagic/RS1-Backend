using System;
using eRezervacija.API.Helpers;
using eRezervacija.Core;
using eRezervacija.Repository;
using eRezervacija.Service;
using eRezervacija.API.ViewModels;
using Microsoft.AspNetCore.Http;
using eRezervacija.Core.Autentikacija;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eRezervacija.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DrzavaController : ControllerBase
    {
        IDrzavaService drzavaService;
        public DrzavaController(IDrzavaService drzavaService)
        {
            this.drzavaService = drzavaService;
        }

        [HttpPost]
        //[Autorizacija(Admin: true, Vlasnik: false, Gost: false)]
        public Drzava AddDrzava(Drzava drzava)
        {
            var novaDrzava = new Drzava()
            {
                Name = drzava.Name
            };
            drzavaService.Add(novaDrzava);
            return novaDrzava;
        }

        [HttpGet]
        //[Autorizacija(Admin: true, Vlasnik: true, Gost: true)]
        public IEnumerable<Drzava> GetAll()
        {
            return drzavaService.GetAll();
        }

        [HttpDelete]
        //[Autorizacija(Admin: true, Vlasnik: false, Gost: false)]
        public Drzava DeleteDrzava(Drzava drzava)
        {
            var removeana = drzava;
            drzavaService.Remove(drzava);
            return removeana;
        }


        //[HttpDelete ("{drzavaId}")]
        //public Drzava DeleteByDrzavaId(Drzava drzava)
        //{
        //var removeana = drzava;
        //drzavaService.RemoveById(drzava.Id);
        //   return removeana;
        //}

    }
}

