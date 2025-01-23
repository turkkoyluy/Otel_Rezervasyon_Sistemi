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
    public class ReservationService
    {
        ReservationDAL _reservationDAL = new ReservationDAL();
        RoomService _roomService = new RoomService();

        public DataTable GetDataTable()
        { 
            return _reservationDAL.GetDataTable();
        }
        public bool DeleteReservation(Reservation reservation) 
        {
            _roomService.ChangeStatusActive(reservation.RoomId);
           return _reservationDAL.DeleteReservation(reservation.ReservationId);
        }
        public void AddReservation(Reservation reservation) 
        {  
            _reservationDAL.AddReservation(reservation);
            _roomService.ChangeStatusDeactive(reservation.RoomId);
        }
        public void UpdateReservation(Reservation reservation) 
        {
            _reservationDAL.UpdateReservation(reservation);
        }
        public int GetLastReservationId() 
        {
         return _reservationDAL.GetLastReservationId();
        }
    }
}
