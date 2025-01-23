using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.DOMAIN
{
    public class Invoice
    {
        public int invoiceID { get; set; }
        public int reservation_id { get; set; }
        public decimal amount { get; set; }
        public DateTime invoiceDate { get; set; }
    }
}
