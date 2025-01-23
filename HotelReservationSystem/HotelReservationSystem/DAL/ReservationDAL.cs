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
    public class ReservationDAL
    {
        dbBaglanti db = new dbBaglanti();

        public DataTable GetDataTable() 
        {
            string query = "SELECT reservation_id,roomNo,TblGuest.guestNameSurname,startDate,endDate FROM TblReservation inner join TblGuest ON TblReservation.guest_id=TblGuest.guest_id inner join TblRoom ON TblReservation.room_id=TblRoom.room_id";
            MySqlCommand cmd = new MySqlCommand(query,db.baglantiGetir());
            //MySqlCommand: SQL sorgusunu çalıştırmak için kullanılır
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //MySqlDataAdapter: Veritabanından veri çekmek ve bellekte DataTable veya DataSet nesnelerine doldurmak için kullanılır.
            DataTable dataTable = new DataTable();
            //Bellekte bir tabloyu temsil eden bir veri yapısıdır. Satırlar ve sütunlardan oluşur.
            adapter.Fill(dataTable);
            //data tableyi gelen veriler ile dolduruyoruz.TblReservation tablosundaki veriler dataTable nesnesine aktarılır.
            return dataTable;
        }
        public bool DeleteReservation(int id) 
        {
            string query = "DELETE FROM TblReservation WHERE reservation_id="+id;
            MySqlCommand cmd = new MySqlCommand( query,db.baglantiGetir());
            
            if (cmd.ExecuteNonQuery()!=0)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
        public int GetLastReservationId() 
        {
            string query = "SELECT MAX(`reservation_id`) FROM TblReservation";
            MySqlCommand cmd = new MySqlCommand(query,db.baglantiGetir());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            return 0;
        }
        public void AddReservation(Reservation reservation) 
        {
            string startdate = reservation.startDate.Date.ToString("yyyy-MM-dd");//tarih verisini mysqldeki istediği formata çeviriyoruz normalde 19.01.2025 ise 19-01-2025
            string enddate = reservation.endDate.Date.ToString("yyyy-MM-dd");
            Console.WriteLine(startdate + "----"+ enddate);
            string query = " INSERT INTO TblReservation(room_id, guest_id, startDate, endDate) VALUES("+reservation.RoomId+","+reservation.GuestId+",'"+ startdate + "' ,'"+enddate+"')";
            MySqlCommand mySqlCommand = new MySqlCommand(query, db.baglantiGetir());
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateReservation(Reservation reservation)
        {
            string startdate = reservation.startDate.Date.ToString("yyyy-MM-dd");//tarih verisini mysqldeki istediği formata çeviriyoruz normalde 19.01.2025 ise 19-01-2025
            string enddate = reservation.endDate.Date.ToString("yyyy-MM-dd");

            string query = "UPDATE TblReservation SET `startDate`='"+startdate+"',`endDate`='"+enddate+"' WHERE reservation_id="+reservation.ReservationId;
             MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
             command.ExecuteNonQuery();
            
        }
    }
}
