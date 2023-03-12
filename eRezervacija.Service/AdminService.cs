using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
	public interface IAdminService
	{
		void Add(Admin obj);
		IEnumerable<Admin> GetAll();
		Admin GetByKorisnikID(int id);
	}
	public class AdminService : IAdminService
	{
		IRepository<Admin> adminRepository;
		public AdminService(IRepository<Admin> adminRepository)
		{
			this.adminRepository = adminRepository;
		}
		public void Add(Admin obj)
		{
			adminRepository.Add(obj);
		}

		public IEnumerable<Admin> GetAll()
		{
			return adminRepository.GetAll();
		}

		public Admin GetByKorisnikID(int id)
		{
			return adminRepository.GetAll().Where(k => k.KorisnikID == id).FirstOrDefault();
		}
	}
}
