using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// 📁 Utils/FormValidator.cs
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TinyHauseProject.Utils
{
    public static class FormValidator
    {
        public static bool EmailGecerliMi(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
        }

        public static bool SifreGecerliMi(string sifre)
        {
            return !Regex.IsMatch(sifre, @"[<>'';--]");
        }

        public static bool SayiMi(string giris)
        {
            return Regex.IsMatch(giris, @"^\d+$");
        }

        public static void SadeceSayiGirisi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
