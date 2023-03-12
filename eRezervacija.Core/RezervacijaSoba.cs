using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
    public class RezervacijaSoba
    {
        [ForeignKey("RezervacijaID")]
        public Rezervacija rezervacija { get; set; }
        public int RezervacijaID { get; set; }
        
        [ForeignKey("SobaID")]
        public Soba soba { get; set; }
        public int SobaID { get; set; }
    }
}
