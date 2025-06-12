using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TinyHauseProject.Config;
using TinyHauseProject.Models;

namespace TinyHauseProject.Services
{
    public class EvService
    {
        // 1. Tüm aktif evleri listele (kiracılar için)
        public List<Ev> AktifEvleriGetir()
        {
            List<Ev> evler = new List<Ev>();
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evler WHERE Aktif = 1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    evler.Add(new Ev
                    {
                        EvID = Convert.ToInt32(reader["EvID"]),
                        SahipID = Convert.ToInt32(reader["SahipID"]),
                        Baslik = reader["Baslik"].ToString(),
                        Aciklama = reader["Aciklama"].ToString(),
                        Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                        Konum = reader["Konum"].ToString(),
                        FotoUrl = reader["FotoUrl"].ToString(),
                        Aktif = Convert.ToBoolean(reader["Aktif"]),
                        EklenmeTarihi = Convert.ToDateTime(reader["EklenmeTarihi"])
                    });
                }
            }
            return evler;
        }

        // 2. Belirli ev sahibine ait evleri getir
        public List<Ev> EvSahibininEvleri(int sahipID)
        {
            List<Ev> evler = new List<Ev>();
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evler WHERE SahipID = @SahipID", conn);
                cmd.Parameters.AddWithValue("@SahipID", sahipID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    evler.Add(new Ev
                    {
                        EvID = Convert.ToInt32(reader["EvID"]),
                        SahipID = Convert.ToInt32(reader["SahipID"]),
                        Baslik = reader["Baslik"].ToString(),
                        Aciklama = reader["Aciklama"].ToString(),
                        Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                        Konum = reader["Konum"].ToString(),
                        FotoUrl = reader["FotoUrl"].ToString(),
                        Aktif = Convert.ToBoolean(reader["Aktif"]),
                        EklenmeTarihi = Convert.ToDateTime(reader["EklenmeTarihi"])
                    });
                }
            }
            return evler;
        }

        // 3. Yeni ev ekle (Stored Procedure ile)
        public bool YeniEvEkle(Ev yeniEv)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("EXEC SP_EvEkle @SahipID, @Baslik, @Aciklama, @Fiyat, @Konum, @FotoUrl", conn);
                cmd.Parameters.AddWithValue("@SahipID", yeniEv.SahipID);
                cmd.Parameters.AddWithValue("@Baslik", yeniEv.Baslik);
                cmd.Parameters.AddWithValue("@Aciklama", yeniEv.Aciklama);
                cmd.Parameters.AddWithValue("@Fiyat", yeniEv.Fiyat);
                cmd.Parameters.AddWithValue("@Konum", yeniEv.Konum);
                cmd.Parameters.AddWithValue("@FotoUrl", (object)yeniEv.FotoUrl ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // (İsteğe bağlı) Ev durumu güncelleme
        public void EvDurumDegistir(int evID, bool aktifMi)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Evler SET Aktif = @Aktif WHERE EvID = @EvID", conn);
                cmd.Parameters.AddWithValue("@EvID", evID);
                cmd.Parameters.AddWithValue("@Aktif", aktifMi ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
