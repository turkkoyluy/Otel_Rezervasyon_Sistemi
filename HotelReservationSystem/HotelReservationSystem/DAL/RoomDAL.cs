using HotelReservationSystem.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.DAL
{
     public class RoomDAL
    {
        dbBaglanti db=new dbBaglanti();
         
        public void RoomAdd(Room room) 
        {
            string query= "INSERT INTO TblRoom( roomNo, roomType, price, isAvailable) VALUES (@roomNo,@roomType,@price,true)";
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            command.Parameters.AddWithValue("@roomNo",room.roomNo);
            command.Parameters.AddWithValue("@roomType",room.roomType);
            command.Parameters.AddWithValue("@price", room.price);
            command.ExecuteNonQuery();
        }
        public void RoomUpdate(Room room) 
        {
            string query = "UPDATE TblRoom SET roomNo="+room.roomNo+",roomType='"+room.roomType+"',price="+room.price+",isAvailable="+room.isAvaliable+" WHERE room_id="+room.roomID;
            MySqlCommand command = new MySqlCommand(query,db.baglantiGetir());
            command.ExecuteNonQuery();
        }
        public DataTable GetDataTable() 
        {  
            string query = "Select * From TblRoom ORDER BY isAvailable DESC";
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
            //MysqlCommand ile sorgumuzu çalıştırıyoruz.DataAdapter ile çalıştırdığımız sorgudan gelen verileri data tableye aktarıyoruz.
            
        }
        public DataTable GetAvailableRoomDataTable()
        {
            string query = "Select * From TblRoom Where isAvailable = 1";
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
            //MysqlCommand ile sorgumuzu çalıştırıyoruz.DataAdapter ile çalıştırdığımız sorgudan gelen verileri data tableye aktarıyoruz.

        }

        public int GetRoomCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            int roomCount=Convert.ToInt32 (command.ExecuteScalar());
            return roomCount;
        }

        public void Delete(int id)
        {
            try
            {
                string query = "DELETE FROM TblRoom WHERE room_id=" + id;
                MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                 MessageBox.Show("Seçilen Oda Rezerve Edilmiştir.(Öncelikle rezervasyonu silin veya güncelleyin)");
                
            }
        }

        public void ChangeStatusDeactive(int roomId)
        {
            string query = "UPDATE TblRoom SET isAvailable = 0 WHERE room_id="+roomId;
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            command.ExecuteNonQuery();
        }
        public void ChangeStatusActive(int roomId)
        {
            string query = "UPDATE TblRoom SET isAvailable = 1 WHERE room_id=" + roomId;
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            command.ExecuteNonQuery();
        }

        public int GetRoomPrice(int roomId)
        {
            string query = "SELECT price FROM TblRoom WHERE room_id="+roomId;
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) 
            {
                return reader.GetInt32(0);
            }
            return 0;
        }
    }
}
