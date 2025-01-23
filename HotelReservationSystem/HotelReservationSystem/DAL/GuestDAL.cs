using HotelReservationSystem.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.DAL
{
    public class GuestDAL
    {
        dbBaglanti db = new dbBaglanti();
        public DataTable getGuestNameSurmaneDataTable()
        {
            string query = "Select * From TblGuest";
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void Add(Guest guest)
        {
            string query = "INSERT INTO TblGuest( `guestNameSurname`, `guestNumber`, `guestTCNo`) VALUES ('"+guest.NameSurname+"','"+guest.Number+"','"+guest.TcNo+"')";
            MySqlCommand command = new MySqlCommand(query,db.baglantiGetir());
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM TblGuest WHERE guest_id=" + id;
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            command.ExecuteNonQuery();
        }

        public void Update(Guest guest)
        {
            string query = "UPDATE `TblGuest` SET `guestNameSurname`='"+guest.NameSurname+"',`guestNumber`='"+guest.Number+"',`guestTCNo`='"+guest.TcNo+"' WHERE guest_id="+guest.Id;
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            command.ExecuteNonQuery();
        }
    }
}
