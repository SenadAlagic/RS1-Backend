using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
    public class Recenzija
    {
        [Key]
        public int Id { get; set; }
        public int HotelId { get; set; } //foreign key na hotel koji jos nemamo
        [ForeignKey("GostId")]
        public Gost gost { get; set; }
        public int GostId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    }
}
