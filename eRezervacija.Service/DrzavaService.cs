using System;
using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IDrzavaService
    {
        void Add(Drzava obj);
        IEnumerable<Drzava> GetAll();
        Drzava GetByDrzavaID(int id);
        void Remove(Drzava obj);
        //void RemoveById(int id);
    }

    public class DrzavaService : IDrzavaService
    {
        IRepository<Drzava> drzavaRepository;

        public DrzavaService(IRepository<Drzava> drzavaRepository)
        {
            this.drzavaRepository = drzavaRepository;
        }
        public void Add(Drzava obj)
        {
            drzavaRepository.Add(obj);
        }

        public IEnumerable<Drzava> GetAll()
        {
            return drzavaRepository.GetAll();
        }

        public Drzava GetByDrzavaID(int id)
        {
            return drzavaRepository.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(Drzava obj)
        {
            drzavaRepository.Remove(obj);
        }

        //public void RemoveById(int id)
        //{
        //    var odabranaDrzava = drzavaRepository.GetById(id);
        //    drzavaRepository.Remove(odabranaDrzava);
        //}
    }
}

