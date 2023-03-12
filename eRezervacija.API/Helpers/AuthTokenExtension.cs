using Azure.Core;
using eRezervacija.Core;
using eRezervacija.Core.Autentikacija;
using eRezervacija.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using System.Text.Json.Serialization;

namespace eRezervacija.API.Helpers
{
	public static class AuthTokenExtension
	{
		public class LoginInformacije
		{
			[JsonIgnore]
			public Korisnik? korisnickiNalog => autentifikacijaToken?.korisnik;
			public AutentifikacijaToken? autentifikacijaToken { get; set; }
			public bool isLogiran => korisnickiNalog != null;

			public LoginInformacije(AutentifikacijaToken? autentifikacijaToken)
			{
				this.autentifikacijaToken = autentifikacijaToken;
			}
		}
		public static LoginInformacije GetLoginInfo(this HttpContext httpContext)
		{
			var token = httpContext.GetAuthToken();

			return new LoginInformacije(token);
		}

		public static AutentifikacijaToken? GetAuthToken(this HttpContext httpContext)
		{
			string token = httpContext.GetMyAuthToken();
			eRezervacijaDbContext db = httpContext.RequestServices.GetService<eRezervacijaDbContext>();

			List<AutentifikacijaToken> sviTokeni = db.AutentifikacijaTokeni.ToList();
			AutentifikacijaToken? korisnik = db.AutentifikacijaTokeni
				.Include(s => s.korisnik)
				.SingleOrDefault(x => x.Vrijednost == token);

			return korisnik;
		}


		public static string GetMyAuthToken(this HttpContext httpContext)
		{
			const string header = "autentifikacija-token";
			var token = httpContext.Request.Headers[header];
			return token;
		}
	}
}
