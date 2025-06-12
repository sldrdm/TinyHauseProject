using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TinyHauseProject.Config;
using TinyHauseProject.Models;
using System.Windows.Forms;

namespace TinyHauseProject.Services
{
  
    public class YorumService
    {
        // Belirli bir evin yorumlarını getir
        public List<Yorum> EvYorumlariniGetir(int evId)
        {
            List<Yorum> yorumlar = new List<Yorum>();

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SP_YorumlariGetir", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EvID", evId);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    yorumlar.Add(new Yorum
                    {
                        YorumID = Convert.ToInt32(dr["YorumID"]),
                        EvID = evId,
                        KullaniciID = Convert.ToInt32(dr["KullaniciID"]),
                        Ad = dr["Ad"].ToString(), // Kullanıcı adı
                        Soyad = dr["Soyad"].ToString(),
                        Puan = Convert.ToInt32(dr["Puan"]),
                        YorumMetni = dr["Yorum"].ToString()
                    });
                }
            }

            return yorumlar;
        }

        // Yeni yorum ekle
        public bool YorumEkle(Yorum yeniYorum)
        {
            try
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Yorumlar (EvID, KullaniciID, Puan, Yorum)
                        VALUES (@EvID, @KullaniciID, @Puan, @Yorum)", conn);

                    cmd.Parameters.AddWithValue("@EvID", yeniYorum.EvID);
                    cmd.Parameters.AddWithValue("@KullaniciID", yeniYorum.KullaniciID);
                    cmd.Parameters.AddWithValue("@Puan", yeniYorum.Puan);
                    cmd.Parameters.AddWithValue("@Yorum", yeniYorum.YorumMetni);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                // Trigger hatalarını veya başka sorunları burada yakalayabilirsin
                Console.WriteLine("Yorum eklenemedi: " + ex.Message);
                return false;
            }
        }
    }
}
