using System;
using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
	public interface IHotelDetaljiService
	{
        void Add(HotelDetalji obj);
        IEnumerable<HotelDetalji> GetAll();
        HotelDetalji GetByHotelID(int id);
        void Remove(HotelDetalji obj);
    }

    public class HotelDetaljiService : IHotelDetaljiService
    {
        IRepository<HotelDetalji> hotelDetaljiRepository;

        public HotelDetaljiService(IRepository<HotelDetalji> hotelDetaljiRepository)
        {
            this.hotelDetaljiRepository = hotelDetaljiRepository;
        }

        public void Add(HotelDetalji obj)
        {
            hotelDetaljiRepository.Add(obj);
        }

        public IEnumerable<HotelDetalji> GetAll()
        {
            return hotelDetaljiRepository.GetAll();
        }

        public HotelDetalji GetByHotelID(int id)
        {
            return hotelDetaljiRepository.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(HotelDetalji obj)
        {
            hotelDetaljiRepository.Remove(obj);
        }
    }
}

