using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    using global::TinyHauseProject.Config;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using TinyHauseProject.Config;
    using TinyHauseProject.Models;

    namespace TinyHauseProject.Services
    {
        public class KullaniciService
        {
            public Kullanici KullaniciGetir(string email, string sifre)
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Email = @Email AND Sifre = @Sifre AND Aktif = 1", conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Kullanici
                            {
                                KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                Email = reader["Email"].ToString(),
                                Rol = Convert.ToByte(reader["Rol"]),
                                Aktif = Convert.ToBoolean(reader["Aktif"])
                            };
                        }
                    }
                }
                return null;
            }

            public bool YeniKullaniciEkle(Kullanici yeniKullanici)
            {
                using (SqlConnection conn = Veritabani.BaglantiGetir())
                {
                    SqlCommand cmd = new SqlCommand("EXEC SP_YeniKullaniciEkle @Ad, @Soyad, @Email, @Sifre, @Rol", conn);
                    cmd.Parameters.AddWithValue("@Ad", yeniKullanici.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", yeniKullanici.Soyad);
                    cmd.Parameters.AddWithValue("@Email", yeniKullanici.Email);
                    cmd.Parameters.AddWithValue("@Sifre", yeniKullanici.Sifre);
                    cmd.Parameters.AddWithValue("@Rol", yeniKullanici.Rol);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }

