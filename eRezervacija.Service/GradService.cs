using System;
using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
	public interface IGradService
	{
		void Add(Grad obj);
        IEnumerable<Grad> GetAll();
		Grad GetByGradID(int id);
        void DodajHotelUGradu(int id);
    }

    public class GradService : IGradService
    {
        IRepository<Grad> gradRepository;

        public GradService(IRepository<Grad> gradRepository)
        {
            this.gradRepository = gradRepository;
        }

        public void Add(Grad obj)
        {
            gradRepository.Add(obj);
        }

        public void DodajHotelUGradu(int id)
        {
            var tajGrad=GetByGradID(id);
            tajGrad.BrojHotelaUGradu++;
            gradRepository.Update(tajGrad);
        }

        public IEnumerable<Grad> GetAll()
        {
            return gradRepository.GetAll();
        }

        public Grad GetByGradID(int id)
        {
            return gradRepository.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}

