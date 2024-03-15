using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class DataModal
    {
        SqlConnection con; SqlCommand cmd;

        public DataModal()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Admin Giriş

        public Admins AdminGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Adminler WHERE KullaniciAdi = @ka AND Sifre = @sif";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sif", sifre);
                con.Open();
                int kontrol = Convert.ToInt32(cmd.ExecuteScalar());
                if (kontrol > 0)
                {
                    cmd.CommandText = "SELECT ID, KullaniciAdi, Sifre FROM Adminler WHERE KullaniciAdi = @ka AND Sifre = @sif";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sif", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Admins admin = new Admins();
                    while (reader.Read())
                    {
                        admin.ID = reader.GetInt32(0);
                        admin.KullaniciAdi = reader.GetString(1);
                        admin.Sifre = reader.GetString(2);
                    }
                    return admin;
                }
                return null;
            }
            catch
            {
                return null;
            }

            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
