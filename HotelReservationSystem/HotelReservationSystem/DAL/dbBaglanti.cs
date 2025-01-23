using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HotelReservationSystem.DAL
{
     class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330050; Uid=25_132330050; Pwd=!nif.ogr50TU");

            baglanti.Open();
                Console.WriteLine("connection success");
                return baglanti;
        }
       
    }
}
