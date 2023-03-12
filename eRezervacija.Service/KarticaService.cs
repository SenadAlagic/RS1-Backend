using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IKarticaService
    {
        void Add(KreditnaKartica obj);
        IEnumerable<KreditnaKartica> GetAll();
        KreditnaKartica GetByKarticaID(int id);
        void Remove(KreditnaKartica obj);
    }

    public class KarticaService : IKarticaService
    {
        IRepository<KreditnaKartica> karticaRepository;

        public KarticaService(IRepository<KreditnaKartica> karticaRepository)
        {
            this.karticaRepository = karticaRepository;
        }

        public void Add(KreditnaKartica obj)
        {
            karticaRepository.Add(obj);
        }

        public IEnumerable<KreditnaKartica> GetAll()
        {
            return karticaRepository.GetAll();
        }

        public KreditnaKartica GetByKarticaID(int id)
        {
            return karticaRepository.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(KreditnaKartica obj)
        {
            karticaRepository.Remove(obj);
        }
    }
}
