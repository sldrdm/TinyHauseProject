using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;

namespace TinyHauseProject.Utils
{
    public static class HelperFunctions
    {
        // Tarihi Türkçe biçimde döndür
        public static string TarihGoster(DateTime tarih)
        {
            return tarih.ToString("dd MMMM yyyy", new CultureInfo("tr-TR"));
        }

        // Tutarı ₺ ile birlikte biçimlendir
        public static string ParaBicimlendir(decimal tutar)
        {
            return string.Format(new CultureInfo("tr-TR"), "{0:C2}", tutar);
        }

        // JSON biçimindeki fotoğraf URL listesini ayrıştır (Newtonsoft.Json kullanılır)
        public static List<string> FotoUrlListesiGetir(string jsonText)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<string>>(jsonText) ?? new List<string>();
            }
            catch
            {
                return new List<string> { "Hatalı JSON" };
            }
        }

        // Rezervasyon durumu metnini döndür
        public static string RezervasyonDurumMetni(int durumKodu)
        {
            switch (durumKodu)
            {
                case 0:
                    return "Bekliyor";
                case 1:
                    return "Onaylandı";
                case 2:
                    return "İptal Edildi";
                default:
                    return "Bilinmiyor";
            }
        }

        // Ödeme durumu metni
        public static string OdemeDurumMetni(int odemeKodu)
        {
            switch (odemeKodu)
            {
                case 0:
                    return "Bekliyor";
                case 1:
                    return "Ödendi";
                case 2:
                    return "İptal";
                default:
                    return "Bilinmiyor";
            }
        }
    }
}
