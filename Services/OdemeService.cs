using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TinyHauseProject.Config;
using TinyHauseProject.Models;

namespace TinyHauseProject.Services
{
    public class OdemeService
    {
        // Ödeme listesini getir
        public List<Odeme> OdemeleriGetir()
        {
            List<Odeme> liste = new List<Odeme>();

            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Odemeler", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Odeme
                    {
                        OdemeID = Convert.ToInt32(dr["OdemeID"]),
                        RezervasyonID = Convert.ToInt32(dr["RezervasyonID"]),
                        Tutar = Convert.ToDecimal(dr["Tutar"]),
                        OdemeTarihi = dr["OdemeTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["OdemeTarihi"]),
                        OdemeDurumu = Convert.ToInt16(dr["OdemeDurumu"]),
                        Aktif = Convert.ToBoolean(dr["Aktif"])
                    });
                }
                dr.Close();
            }

            return liste;
        }

        // Yeni ödeme ekle
        public bool OdemeEkle(Odeme odeme)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Odemeler (RezervasyonID, Tutar, OdemeDurumu, Aktif)
                    VALUES (@RezervasyonID, @Tutar, @OdemeDurumu, @Aktif)", conn);

                cmd.Parameters.AddWithValue("@RezervasyonID", odeme.RezervasyonID);
                cmd.Parameters.AddWithValue("@Tutar", odeme.Tutar);
                cmd.Parameters.AddWithValue("@OdemeDurumu", odeme.OdemeDurumu);
                cmd.Parameters.AddWithValue("@Aktif", odeme.Aktif);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Belirli rezervasyonun ödemesini getir
        public Odeme OdemeGetirByRezervasyonID(int rezervasyonID)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Odemeler WHERE RezervasyonID = @RezervasyonID", conn);
                cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new Odeme
                    {
                        OdemeID = Convert.ToInt32(dr["OdemeID"]),
                        RezervasyonID = Convert.ToInt32(dr["RezervasyonID"]),
                        Tutar = Convert.ToDecimal(dr["Tutar"]),
                        OdemeTarihi = dr["OdemeTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["OdemeTarihi"]),
                        OdemeDurumu = Convert.ToInt16(dr["OdemeDurumu"]),
                        Aktif = Convert.ToBoolean(dr["Aktif"])
                    };
                }
            }

            return null;
        }

        // Ödeme durumu güncelle
        public bool OdemeDurumuGuncelle(int odemeID, short yeniDurum)
        {
            using (SqlConnection conn = Veritabani.BaglantiGetir())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Odemeler SET OdemeDurumu = @OdemeDurumu WHERE OdemeID = @ID", conn);
                cmd.Parameters.AddWithValue("@OdemeDurumu", yeniDurum);
                cmd.Parameters.AddWithValue("@ID", odemeID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}