using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static HotelReservationSystem.DAL.AdminDAL;
using HotelReservationSystem.DOMAIN;
using MySql.Data.MySqlClient;
using HotelReservationSystem.DAL; // Admin sınıfının bulunduğu namespace



namespace HotelReservationSystem.SERVICES
{
    public class AdminService
    {
            private  AdminDAL adminDal = new AdminDAL();

        public Admin Login(Admin admin)
        {
            // Admin bilgilerini kontrol etmek için GetAdminByEmailAndPassword çağrılır
            Admin _admin = adminDal.GetAdminByEmailAndPassword(admin);
            if (_admin!=null)
            {
                return _admin;
            } // Eğer null değilse giriş başarılıdır
            return null;
        }

    }


}

