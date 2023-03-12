using eRezervacija.API.Helpers;
using eRezervacija.API.ViewModels;
using eRezervacija.Core;
using eRezervacija.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eRezervacija.Repository;
using eRezervacija.Core.Autentikacija;

namespace eRezervacija.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class KorisnikController : ControllerBase
	{
		IKorisnikService korisnikService;
		IGostService gostService;
		IAuthTokenService tokenService;
		IAdminService adminService;
		IVlasnikService vlasnikService;
		IKarticaService karticaService;
		IRecenzijaService recenzijaService;
		IRezervacijaService rezervacijaService;
		IRezervacijaSobaService rezervacijaSobaService;
		public KorisnikController(IKorisnikService korisnikService, IGostService gostService, IAuthTokenService tokenService,
			IAdminService adminService, IVlasnikService vlasnikService, IKarticaService karticaService, IRecenzijaService recenzijaService,
			IRezervacijaService rezervacijaService, IRezervacijaSobaService rezervacijaSobaService)
		{
			this.korisnikService = korisnikService;
			this.gostService = gostService;
			this.tokenService = tokenService;
			this.adminService = adminService;
			this.vlasnikService = vlasnikService;
			this.karticaService = karticaService;
			this.recenzijaService = recenzijaService;
			this.rezervacijaService = rezervacijaService;
			this.rezervacijaSobaService = rezervacijaSobaService;
		}

		[HttpPost]
		public Gost RegistracijaGost(RegistracijaGostVM gost)
		{
			if (korisnikService.CheckIfExisting(gost.Username))
				return null;
			var temp = new Korisnik()
			{
				Uloga = "Gost",
				Ime = gost.Ime,
				Prezime = gost.Prezime,
				Spol = gost.Spol,
				Datum_rodjenja = gost.DatumRodjenja,
				Email = gost.Email,
				Broj_telefona = gost.BrojTelefona,
				Username = gost.Username,
				Password = gost.Password,
				DatumKreiranja = DateTime.Now,
				DatumPromjene = DateTime.Now,
			};
			korisnikService.Add(temp);
			var novaKartica = new KreditnaKartica()
			{
				BrojKartice = "",
				SSV = 0,
				DatumIsteka = ""
			};
			karticaService.Add(novaKartica);
			var noviGost = new Gost()
			{
				korisnik = temp,
				//KorisnikID = korisnikService.Get(temp).Id,
				kartica = novaKartica
			};
			gostService.Add(noviGost);
			return noviGost;
		}
		[HttpPost]
		public ActionResult<AuthTokenExtension.LoginInformacije> LoginGost([FromBody] LoginVM x)
		{
			//provjeriti login
			Korisnik? logiraniKorisnik = korisnikService.GetByLogin(x.Username, x.Password, "Gost");
			if (logiraniKorisnik == null)
			{
				//pogresan username ili password
				return new AuthTokenExtension.LoginInformacije(null);
			}

			//generisanje random stringa
			string randomString = TokenGenerator.Generate(10);

			//dodavanje novog zapisa u tabelu AutentifikacijaToken za taj login i string
			var noviToken = new AutentifikacijaToken()
			{
				ipAdresa = Request.HttpContext.Connection.RemoteIpAddress?.ToString(),
				Vrijednost = randomString,
				korisnik = logiraniKorisnik,
				gost = gostService.GetByKorisnikID(logiraniKorisnik.Id),
			};
			tokenService.Add(noviToken);
			return new AuthTokenExtension.LoginInformacije(noviToken);
		}
		[HttpGet]
		public IEnumerable<Gost> GetAllGost()
		{
			return gostService.GetAll();
		}

		[HttpPost]
		public Admin RegistracijaAdmin(RegistracijaAdminVM admin)
		{
			if (korisnikService.CheckIfExisting(admin.Username))
				return null;
			var temp = new Korisnik()
			{
				Uloga = "Admin",
				Ime = admin.Ime,
				Prezime = admin.Prezime,
				Spol = admin.Spol,
				Datum_rodjenja = admin.DatumRodjenja,
				Email = admin.Email,
				Broj_telefona = admin.BrojTelefona,
				Username = admin.Username,
				Password = admin.Password,
				DatumKreiranja = DateTime.Now,
				DatumPromjene = DateTime.Now,
			};
			korisnikService.Add(temp);
			var noviAdmin = new Admin()
			{
				korisnik = temp
			};
			adminService.Add(noviAdmin);
			return noviAdmin;
		}
		[HttpPost]
		public ActionResult<AuthTokenExtension.LoginInformacije> LoginAdmin([FromBody] LoginVM x)
		{
			Korisnik? logiraniKorisnik = korisnikService.GetByLogin(x.Username, x.Password, "Admin");
			if (logiraniKorisnik == null)
			{
				return new AuthTokenExtension.LoginInformacije(null);
			}
			string randomString = TokenGenerator.Generate(10);

			var noviToken = new AutentifikacijaToken()
			{
				ipAdresa = Request.HttpContext.Connection.RemoteIpAddress?.ToString(),
				Vrijednost = randomString,
				korisnik = logiraniKorisnik,
				admin = adminService.GetByKorisnikID(logiraniKorisnik.Id),
			};
			tokenService.Add(noviToken);
			return new AuthTokenExtension.LoginInformacije(noviToken);
		}
		[HttpGet]
		public IEnumerable<Admin> GetAllAdmin()
		{
			return adminService.GetAll();
		}


		[HttpPost]
		public Vlasnik RegistracijaVlasnik(RegistracijaVlasnikVM vlasnik)
		{
			if (korisnikService.CheckIfExisting(vlasnik.Username))
				return null;
			var temp = new Korisnik()
			{
				Uloga = "Vlasnik",
				Ime = vlasnik.Ime,
				Prezime = vlasnik.Prezime,
				Spol = vlasnik.Spol,
				Datum_rodjenja = vlasnik.DatumRodjenja,
				Email = vlasnik.Email,
				Broj_telefona = vlasnik.BrojTelefona,
				Username = vlasnik.Username,
				Password = vlasnik.Password,
				DatumKreiranja = DateTime.Now,
				DatumPromjene = DateTime.Now,
			};
			korisnikService.Add(temp);
			var noviVlasnik = new Vlasnik()
			{
				korisnik = temp,
				//KorisnikID = korisnikService.Get(temp).Id,
				BrojBankovnogRacuna = vlasnik.BrojBankovnogRacuna,
				BrojLicneKarte = vlasnik.BrojLicneKarte
				//VlasnickiList = vlasnik.VlasnickiList
			};
			vlasnikService.Add(noviVlasnik);
			return noviVlasnik;
		}
		[HttpPost]
		public ActionResult<AuthTokenExtension.LoginInformacije> LoginVlasnik([FromBody] LoginVM x)
		{
			//provjeriti login
			Korisnik? logiraniKorisnik = korisnikService.GetByLogin(x.Username, x.Password, "Vlasnik");
			if (logiraniKorisnik == null)
			{
				//pogresan username ili password
				return new AuthTokenExtension.LoginInformacije(null);
			}

			//generisanje random stringa
			string randomString = TokenGenerator.Generate(10);

			//dodavanje novog zapisa u tabelu AutentifikacijaToken za taj login i string
			var noviToken = new AutentifikacijaToken()
			{
				ipAdresa = Request.HttpContext.Connection.RemoteIpAddress?.ToString(),
				Vrijednost = randomString,
				korisnik = logiraniKorisnik,
				vlasnik = vlasnikService.GetByKorisnikID(logiraniKorisnik.Id),
			};
			tokenService.Add(noviToken);
			return new AuthTokenExtension.LoginInformacije(noviToken);
		}
		[HttpGet]
		public IEnumerable<Vlasnik> GetAllVlasnik()
		{
			return vlasnikService.GetAll();
		}

		[HttpPost]
		public ActionResult Logout()
		{
			AutentifikacijaToken autentifikacijaToken = HttpContext.GetAuthToken();

			if (autentifikacijaToken == null)
				return Ok();

			tokenService.Remove(autentifikacijaToken);
			return Ok();
		}
		[HttpGet]
		public IEnumerable<Korisnik> GetAllKorisnik()
		{
			return korisnikService.GetAll();
		}

		[HttpPost]
		//[Autorizacija(Admin: false, Vlasnik: false, Gost: true)]
		public KreditnaKartica PoveziKarticu(int gostId, [FromBody] KreditnaKarticaVM kartica)
		{
			var novakartica = new KreditnaKartica()
			{
				BrojKartice = kartica.BrojKartice,
				SSV = kartica.SSV,
				DatumIsteka = kartica.DatumIsteka
			};
			karticaService.Add(novakartica);
			var temp = gostService.GetByKorisnikID(gostId);
			temp.kartica = novakartica;
			gostService.Update(temp);
			return novakartica;
		}

		[HttpPost]
		public Recenzija DodajRecenziju([FromBody] RecenzijaAddVM recenzija)
		{
			var novaRecenzija = new Recenzija()
			{
				HotelId = recenzija.HotelId,
				GostId = recenzija.GostId,
				Ocjena = recenzija.Ocjena,
				Komentar = recenzija.Komentar
			};
			recenzijaService.Add(novaRecenzija);
			return novaRecenzija;
		}
		[HttpGet]
		public List<Recenzija> GetRecenzijeByGostId(int gostId)
		{
			return recenzijaService.GetByGostId(gostId).ToList();
		}
		[HttpGet]
		public List<Recenzija> GetAllRecenzije()
		{
			return recenzijaService.GetAll().ToList();
		}

		[HttpPost]
		public Rezervacija RezervisiSmjestaj(RezervacijaAddVM rezervacija)
		{
			var novaRezervacija = new Rezervacija()
			{
				GostId = rezervacija.GostId,
				DatumRezervacije = rezervacija.DatumRezervacije,
				DatumCheckIn = rezervacija.DatumCheckIn,
				DatumCheckOut = rezervacija.DatumCheckOut,
				BrojGostiju = rezervacija.BrojGostiju,
				BrojOdraslih = rezervacija.BrojOdraslih,
				BrojDjece = rezervacija.BrojDjece,
				NacinPlacanja = rezervacija.NacinPlacanja,
				Cijena = rezervacija.Cijena,
			};
			var novaRezervacijaSoba = new RezervacijaSoba()
			{
				rezervacija = novaRezervacija,
				SobaID = rezervacija.SobaId
			};
			rezervacijaSobaService.Add(novaRezervacijaSoba);
			rezervacijaService.Add(novaRezervacija);
			return novaRezervacija;
		}
	}
}
