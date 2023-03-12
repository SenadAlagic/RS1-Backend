using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IRecenzijaService
    {
        void Add(Recenzija obj);
        IEnumerable<Recenzija> GetAll();
        IEnumerable<Recenzija> GetByGostId(int gostId);
    }
    public class RecenzijaService : IRecenzijaService
    {
        IRepository<Recenzija> recenzijaRepository;
        public RecenzijaService(IRepository<Recenzija> recenzijaRepository)
        {
            this.recenzijaRepository = recenzijaRepository;
        }
        public void Add(Recenzija obj)
        {
            recenzijaRepository.Add(obj);
        }

        public IEnumerable<Recenzija> GetAll()
        {
            return recenzijaRepository.GetAll();
        }

        public IEnumerable<Recenzija> GetByGostId(int gostId)
        {
            return recenzijaRepository.GetAll().Where(r => r.GostId == gostId);
        }
    }
}
