using eRezervacija.Core;
using eRezervacija.Repository;
using System.Security.Cryptography.X509Certificates;

namespace eRezervacija.Service
{
	public interface IKorisnikService
	{
		void Add(Korisnik obj);
		Korisnik Get(Korisnik obj);
		Korisnik GetByLogin(string username, string password,string uloga);
		bool CheckIfExisting(string username);
		IEnumerable<Korisnik> GetAll();
	}
	public class KorisnikService : IKorisnikService
	{
		IRepository<Korisnik> korisnikRepository;
		public KorisnikService(IRepository<Korisnik> korisnikRepository)
		{
			this.korisnikRepository = korisnikRepository;
		}

		public void Add(Korisnik obj)
		{
			korisnikRepository.Add(obj);
		}

		public IEnumerable<Korisnik> GetAll()
		{
			return korisnikRepository.GetAll();
		}

		public Korisnik Get(Korisnik obj)
		{
			return korisnikRepository.GetAll().Where(x => x.Username==obj.Username).First();
		}

		public Korisnik GetByLogin(string username, string password, string uloga)
		{
			//je li ovo najbolja implementacija?
			Korisnik? logiraniKorisnik=korisnikRepository.GetAll().FirstOrDefault(k=>k.Username==username && k.Password==password && k.Uloga==uloga);
			return logiraniKorisnik;
		}

		public bool CheckIfExisting(string username)
		{
			Korisnik? postojeci = korisnikRepository.GetAll().Where(x => x.Username == username).FirstOrDefault();
			return !(postojeci == null);
			//vrati true ako je username vec postojeci
		}
	}
}