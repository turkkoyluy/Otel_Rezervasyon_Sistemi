using MySql.Data.MySqlClient;
using System;
using HotelReservationSystem.DOMAIN;
using System.Data;

namespace HotelReservationSystem.DAL
{
    public class AdminDAL
    {
                dbBaglanti db = new dbBaglanti();           
            public Admin GetAdminByEmailAndPassword(Admin admin)
        {
            string query = "SELECT * FROM TblAdmin WHERE adminMail = '" + admin.mail + "' AND password = " + admin.password;//select sorgumuz.
            using (MySqlDataReader reader = new MySqlCommand(query, db.baglantiGetir()).ExecuteReader())
                //MySqlDataReader, sorgudan dönen verileri satır satır okumanıza olanak tanır.
                //query değişkenindeki SQL sorgusunu çalıştırmak için bir MySqlCommand nesnesi oluşturur. ve veri tabanına bağlanıp sorguyu çalıştırmamızı sağlar
                //.ExecuteReader(): Bu, sorguyu çalıştırır ve sonucu bir MySqlDataReader nesnesine döndürür.
            {
                while (reader.Read())//sorgudan gelen verileri satır satır okuduğumuz döngünün başlangıcı
                {
                    if (reader[2].ToString() == admin.mail && Convert.ToInt32(reader[3]) == admin.password)//gelen veriler giriş yapılan veriler ile aynı mı diye kontrol ediliyor.

                    {
                        return new Admin { id = (int)reader[0], nameSurname = reader[1].ToString(), mail = reader[2].ToString(), password = (int)reader[3] };
                           
                           
                             
                       
                    }
                }
            }
            return null; // Kullanıcı bulunamadı
        }
    }
}

