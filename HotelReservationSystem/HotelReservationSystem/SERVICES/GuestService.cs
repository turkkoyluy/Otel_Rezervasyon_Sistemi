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
    public class GuestService
    {
       private GuestDAL _guestDAL = new GuestDAL(); 

        public DataTable getGuestNameSurmaneDataTable() 
        {
            return _guestDAL.getGuestNameSurmaneDataTable();
        }

        public void Add(Guest guest)
        {
            _guestDAL.Add(guest);
        }

        public void Delete(int id)
        {
            _guestDAL.Delete(id);
        }

        public void Update(Guest guest)
        {
            _guestDAL.Update(guest);
        }
    }
}
