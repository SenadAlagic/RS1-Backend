using eRezervacija.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eRezervacija.API.ViewModels
{
    public class RecenzijaAddVM
    {
        public int HotelId { get; set; } //foreign key na hotel koji jos nemamo
        public int GostId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    }
}
