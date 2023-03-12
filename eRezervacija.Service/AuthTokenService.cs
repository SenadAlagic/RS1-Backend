using eRezervacija.Core.Autentikacija;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
	public interface IAuthTokenService
	{
		void Add(AutentifikacijaToken obj);
		void Remove(AutentifikacijaToken obj);
	}
	public class AuthTokenService : IAuthTokenService
	{
		IRepository<AutentifikacijaToken> tokenRepository;
		public AuthTokenService(IRepository<AutentifikacijaToken> tokenRepository)
		{
			this.tokenRepository = tokenRepository;
		}

		public void Add(AutentifikacijaToken obj)
		{
			tokenRepository.Add(obj); 
		}

		public void Remove(AutentifikacijaToken obj)
		{
			tokenRepository.Remove(obj);
		}
	}
}
