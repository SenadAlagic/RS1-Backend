using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IHotelService
	{
		void Add(Hotel obj);
        IEnumerable<Hotel> GetAll();
        Hotel GetByHotelID(int id);
        void Remove(Hotel obj);
    }

	public class HotelService:IHotelService
	{
		IRepository<Hotel> hotelRepository;

        public HotelService(IRepository<Hotel> hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        public void Add(Hotel obj)
        {
            hotelRepository.Add(obj);
        }

        public IEnumerable<Hotel> GetAll()
        {
            return hotelRepository.GetAll();
        }

        public Hotel GetByHotelID(int id)
        {
            return hotelRepository.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(Hotel obj)
        {
            hotelRepository.Remove(obj);
        }
    }
}

