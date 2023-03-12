using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Core
{
    public class KreditnaKartica
    {
        [Key]
        public int Id { get; set; }
        public string BrojKartice { get; set; }
        public int SSV { get; set; }
        public string DatumIsteka { get; set; }
        // 03/24 npr 
    }
}
