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
    public static class RezervasyonService
    {
        public static List<Rezervasyon> EvRezervasyonlariniGetir(int evID)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(@"
            SELECT r.RezervasyonID, r.EvID, r.BaslangicTarihi, r.BitisTarihi, r.Aktif,
                   k.Ad + ' ' + k.Soyad AS KiraciAdSoyad
            FROM Rezervasyonlar r
            INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID
            WHERE r.EvID = @evID", conn);

                Veritabani.ParametreEkle(cmd, "@evID", evID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervasyonID = (int)reader["RezervasyonID"],
                        EvID = (int)reader["EvID"],
                        BaslangicTarihi = Convert.ToDateTime(reader["BaslangicTarihi"]),
                        BitisTarihi = Convert.ToDateTime(reader["BitisTarihi"]),
                        Aktif = (bool)reader["Aktif"],
                        KiraciAdSoyad = reader["KiraciAdSoyad"].ToString()
                    });
                }
            }
            return rezervasyonlar;
        }


        // Kiracının kendi rezervasyonlarını getirir
        public static List<Rezervasyon> KiraciRezervasyonlariniGetir(int kiraciID)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT r.RezervasyonID, r.EvID, r.BaslangicTarihi, r.BitisTarihi, r.Aktif,
                           e.Baslik AS EvBaslik
                    FROM Rezervasyonlar r
                    INNER JOIN Evler e ON r.EvID = e.EvID
                    WHERE r.KiraciID = @kiraciID AND r.Aktif = 1", conn);
                cmd.Parameters.AddWithValue("@kiraciID", kiraciID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervasyonID = (int)reader["RezervasyonID"],
                        EvID = (int)reader["EvID"],
                        BaslangicTarihi = Convert.ToDateTime(reader["BaslangicTarihi"]),
                        BitisTarihi = Convert.ToDateTime(reader["BitisTarihi"]),
                        Aktif = (bool)reader["Aktif"],
                        EvBaslik = reader["EvBaslik"].ToString()
                    });
                }
            }
            return rezervasyonlar;
        }
       

        // Ev sahibinin evine ait rezervasyonlar
        public static List<Rezervasyon> EvSahibiRezervasyonlariniGetir(int sahipID)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT r.RezervasyonID, r.EvID, r.BaslangicTarihi, r.BitisTarihi, r.Aktif,
                           e.Baslik AS EvBaslik, k.Ad + ' ' + k.Soyad AS KiraciAdSoyad
                    FROM Rezervasyonlar r
                    INNER JOIN Evler e ON r.EvID = e.EvID
                    INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID
                    WHERE e.SahipID = @sahipID AND r.Aktif = 1", conn);
                cmd.Parameters.AddWithValue("@sahipID", sahipID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervasyonID = (int)reader["RezervasyonID"],
                        EvID = (int)reader["EvID"],
                        BaslangicTarihi = Convert.ToDateTime(reader["BaslangicTarihi"]),
                        BitisTarihi = Convert.ToDateTime(reader["BitisTarihi"]),
                        Aktif = (bool)reader["Aktif"],
                        EvBaslik = reader["EvBaslik"].ToString(),
                        KiraciAdSoyad = reader["KiraciAdSoyad"].ToString()
                    });
                }
            }
            return rezervasyonlar;
        }

        // Admin tüm rezervasyonları görüntüleyebilir
        public static List<Rezervasyon> TumRezervasyonlariGetir()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT r.RezervasyonID, r.EvID, r.BaslangicTarihi, r.BitisTarihi, r.Aktif,
                           e.Baslik AS EvBaslik, k.Ad + ' ' + k.Soyad AS KiraciAdSoyad
                    FROM Rezervasyonlar r
                    INNER JOIN Evler e ON r.EvID = e.EvID
                    INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervasyonID = (int)reader["RezervasyonID"],
                        EvID = (int)reader["EvID"],
                        BaslangicTarihi = Convert.ToDateTime(reader["BaslangicTarihi"]),
                        BitisTarihi = Convert.ToDateTime(reader["BitisTarihi"]),
                        Aktif = (bool)reader["Aktif"],
                        EvBaslik = reader["EvBaslik"].ToString(),
                        KiraciAdSoyad = reader["KiraciAdSoyad"].ToString()
                    });
                }
            }
            return rezervasyonlar;
        }

        // Rezervasyon iptal et (admin ya da kiracı tarafından)
        public static bool RezervasyonIptalEt(int rezervasyonID)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET Aktif = 0 WHERE RezervasyonID = @id", conn);
                Veritabani.ParametreEkle(cmd, "@id", rezervasyonID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Yeni rezervasyon ekle (trigger kontrolüyle)
        public static bool YeniRezervasyonEkle(Rezervasyon rezervasyon)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Rezervasyonlar (KiraciID, EvID, BaslangicTarihi, BitisTarihi)
                    VALUES (@kiraciID, @evID, @baslangic, @bitis)", conn);

                cmd.Parameters.AddWithValue("@kiraciID", rezervasyon.KiraciID);
                cmd.Parameters.AddWithValue("@evID", rezervasyon.EvID);
                cmd.Parameters.AddWithValue("@baslangic", rezervasyon.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@bitis", rezervasyon.BitisTarihi);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    // Trigger'dan gelen hata mesajı varsa burada yakalanabilir
                    System.Windows.Forms.MessageBox.Show("Rezervasyon eklenemedi: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
