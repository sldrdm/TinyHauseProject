using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TinyHauseProject.Models
{
    public class Odeme
    {
        public int OdemeID { get; set; }
        public int RezervasyonID { get; set; }
        public decimal Tutar { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public short OdemeDurumu { get; set; }
        public bool Aktif { get; set; }
    }
}

