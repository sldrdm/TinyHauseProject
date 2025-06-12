using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyHauseProject.Models
{
    public class Ev
    {
        public int EvID { get; set; }
        public int SahipID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string Konum { get; set; }
        public string FotoUrl { get; set; }
        public bool Aktif { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}

