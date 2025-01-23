using HotelReservationSystem.DAL;
using HotelReservationSystem.DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.SERVICES
{
    public class RoomService
    {
        private readonly RoomDAL _roomDal = new RoomDAL();

        public void Add(Room room)
        {
            _roomDal.RoomAdd(room);
        }
        public void Delete(int id) 
        {
            _roomDal.Delete(id);
        }
        public DataTable GetDataTable()
        {
            return _roomDal.GetDataTable();
        }
        public DataTable GetAvailableRoomDataTable() 
        {
            return _roomDal.GetAvailableRoomDataTable();
        }
        public int RoomCount(string query)
        {
            return _roomDal.GetRoomCount(query);

        }

        public void Update(Room room)
        {
            _roomDal.RoomUpdate(room); 
        }

        public void ChangeStatusDeactive(int roomId)
        {
            _roomDal.ChangeStatusDeactive(roomId);
        }
        public void ChangeStatusActive(int roomId)
        {
            _roomDal.ChangeStatusActive(roomId);
        }

        public int GetRoomPrice(int roomId)
        {
            return _roomDal.GetRoomPrice(roomId);
        }
    }
}
