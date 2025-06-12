using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyHauseProject.Models
{
    public class Yorum
    {

        public int YorumID { get; set; }
        public int EvID { get; set; }
        public int KullaniciID { get; set; }
        public int Puan { get; set; }
        public string YorumMetni { get; set; }
        public string Ad { get; set; }     // JOIN ile gelen kullanıcı adı
        public string Soyad { get; set; }  // JOIN ile gelen kullanıcı soyadı


    }
}
