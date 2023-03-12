using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IRezervacijaSobaService
    {
        void Add(RezervacijaSoba obj);
        IEnumerable<RezervacijaSoba> GetAll();
    }
    public class RezervacijaSobaService: IRezervacijaSobaService
    {
        IRepository<RezervacijaSoba> rezervacijaSobaRepository;
        public RezervacijaSobaService(IRepository<RezervacijaSoba> rezervacijaSobaRepository)
        {
            this.rezervacijaSobaRepository = rezervacijaSobaRepository;
        }
        public void Add(RezervacijaSoba obj)
        {
            rezervacijaSobaRepository.Add(obj);
        }

        public IEnumerable<RezervacijaSoba> GetAll()
        {
            return rezervacijaSobaRepository.GetAll();
        }
    }
}
