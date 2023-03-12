using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IRezervacijaService
    {
        void Add(Rezervacija obj);
        IEnumerable<Rezervacija> GetAll();
        IEnumerable<Rezervacija> GetByGostId(int gostId);
    }
    public class RezervacijaService : IRezervacijaService
    {
        IRepository<Rezervacija> rezervacijaRepository;
        public RezervacijaService(IRepository<Rezervacija> rezervacijaRepository)
        {
            this.rezervacijaRepository = rezervacijaRepository;
        }
        public void Add(Rezervacija obj)
        {
            rezervacijaRepository.Add(obj);
        }

        public IEnumerable<Rezervacija> GetAll()
        {
            return rezervacijaRepository.GetAll();
        }

        public IEnumerable<Rezervacija> GetByGostId(int gostId)
        {
            return rezervacijaRepository.GetAll().Where(r=>r.GostId==gostId);
        }
    }
}
