using eRezervacija.Core;
using eRezervacija.Repository;

namespace eRezervacija.Service
{
    public interface IHotelZahtjevService
	{
		void Add(HotelZahtjev obj);
        IEnumerable<HotelZahtjev> GetAll();
        void Remove(HotelZahtjev obj);
    }

	public class HotelZahtjevService: IHotelZahtjevService
	{
		IRepository<HotelZahtjev> hotelZahtjevRepository;

        public HotelZahtjevService(IRepository<HotelZahtjev> hotelZahtjevRepository)
        {
            this.hotelZahtjevRepository = hotelZahtjevRepository;
        }

        public void Add(HotelZahtjev obj)
        {
			hotelZahtjevRepository.Add(obj);
        }

        public IEnumerable<HotelZahtjev> GetAll()
        {
            return hotelZahtjevRepository.GetAll();
        }
        public void Remove(HotelZahtjev obj)
        {
			hotelZahtjevRepository.Remove(obj);
        }
    }
}

