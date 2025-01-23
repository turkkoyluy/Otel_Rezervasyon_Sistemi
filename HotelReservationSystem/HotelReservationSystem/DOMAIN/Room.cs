using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.DOMAIN
{
    public class Room
    {
        public Room()
        {
                
        }
        public Room(int roomId, int groomNo, string groomType, int gprice, bool gisAvaliable)
        {
            this.roomID = roomId;
            this.roomNo = groomNo;
            this.roomType = groomType;
            this.price = gprice;
            this.isAvaliable = gisAvaliable;
        }
        public Room(int groomNo, string groomType,int gprice,bool gisAvaliable) 
        { 
            this.roomNo=groomNo;
            this.roomType=groomType;
            this.price=gprice;
            this.isAvaliable=gisAvaliable;
        }
        int id;

        public int roomID
        {
            get { return id; }
            set { id = value; }
        }
        int no;

        public int roomNo
        {
            get { return no; }
            set { no = value; }
        }
        string type;

        public string roomType
        {
            get { return type; }
            set { type = value; }
        }
        int roomPrice;
        public int price
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }
        bool available;
        public bool isAvaliable
        {
            get { return available; }
            set { available = value; }
        }
    }
}
