using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("GostId")]
        public Gost gost { get; set; }
        public int GostId { get; set; }

        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumCheckIn { get; set; } 
        public DateTime DatumCheckOut { get; set; }
        public int BrojGostiju { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public string NacinPlacanja { get; set; }
        public double Cijena { get; set; }
    }
}
