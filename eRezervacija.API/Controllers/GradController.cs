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
    public class GradController : ControllerBase
    {
        IGradService gradService;

        public GradController(IGradService gradService)
        {
            this.gradService = gradService;
        }

        [HttpPost]
        //[Autorizacija(Admin: true, Vlasnik: false, Gost: false)]
        public Grad AddGrad(GradVM grad)
        {
            var noviGrad = new Grad()
            {
                Name = grad.Name,
                PostanskiBroj = grad.postanskiBroj,
                DrzavaID = grad.drzavaID,
            };
            if (!string.IsNullOrEmpty(grad.slika))
            {
                noviGrad.slika = grad.slika.parseBase64();
            }
            gradService.Add(noviGrad);
            return noviGrad;
        }

        [HttpGet]
        //[Autorizacija(Admin: true, Vlasnik: true, Gost: true)]
        public IEnumerable<Grad> GetAll()
        {
            return gradService.GetAll();
        }

    }
}

