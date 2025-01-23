using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HotelReservationSystem.DOMAIN
{
    public class Admin
    {
        public int id { get; set; }
        public string nameSurname { get; set; }
        public string mail { get; set; }
        public int password { get; set; }
    }
}    

