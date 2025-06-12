using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TinyHauseProject.Config
{
    public static class Veritabani
    {
        // SQL Server bağlantı cümlesi
        private static readonly string connectionString = "Server=SELDAERDEM\\SQLEXPRESS;Database=TinyHouse;Trusted_Connection=True;";

        /// <summary>
        /// Yeni bir açık SqlConnection döner. Kullandıktan sonra kapatmayı unutma!
        /// </summary>
        public static SqlConnection BaglantiGetir()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                baglanti.Open();
                return baglanti;
            }
            catch (Exception ex)
            {
                throw new Exception("Veritabanı bağlantısı başarısız: " + ex.Message);
            }
        }

        /// <summary>
        /// Belirtilen sorguya göre komut döner
        /// </summary>
        public static SqlCommand KomutOlustur(string sorgu, SqlConnection conn)
        {
            return new SqlCommand(sorgu, conn);
        }

        /// <summary>
        /// SqlCommand içine güvenli parametre eklemek için yardımcı metod
        /// </summary>
        public static void ParametreEkle(SqlCommand cmd, string parametreAdi, object deger)
        {
            cmd.Parameters.AddWithValue(parametreAdi, deger ?? DBNull.Value);
        }

        /// <summary>
        /// Stored Procedure çalıştırıp sonucu DataTable olarak döner
        /// </summary>
        public static DataTable SP_Calistir(string spAdi, Dictionary<string, object> parametreler = null)
        {
            using (SqlConnection conn = BaglantiGetir())
            using (SqlCommand cmd = new SqlCommand(spAdi, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parametreler != null)
                {
                    foreach (var p in parametreler)
                    {
                        // HATA BURADA ÇIKIYOR: @OdemeDurumu parametresi
                        if (p.Key.Equals("@OdemeDurumu", StringComparison.OrdinalIgnoreCase))
                        {
                            var prm = new SqlParameter("@OdemeDurumu", SqlDbType.SmallInt);
                            prm.Value = p.Value ?? DBNull.Value;
                            cmd.Parameters.Add(prm);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                        }
                    }
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
