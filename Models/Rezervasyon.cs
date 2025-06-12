using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyHauseProject.Models
{
    public class Rezervasyon
    { 
        public int RezervasyonID { get; set; }
        public int KiraciID { get; set; }
        public int EvID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool Aktif { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public string EvBaslik { get; set; }
        public string KiraciAdSoyad { get; set; }

    }
}
