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
    public class InvoiceService
    {
        Invoice _invoice = new Invoice();
        InvoiceDAL _invoiceDAL= new InvoiceDAL();

        public void Add(Invoice invoice) 
        {
            _invoiceDAL.Add(invoice);
        }
        public void DeleteInvoiceReservationId(int reservationid)
        { 
            _invoiceDAL.DeleteInvoiceReservationId(reservationid);
        }

            public DataTable GetDataTable()
        { 
        return _invoiceDAL.GetDataTable();
        }
        public List<decimal> MonthlyEarning() 
        {
            return _invoiceDAL.MonthlyEarning();
        }

        public DataTable InvoiceWritePdf(int invoiceid) 
        {
            return _invoiceDAL.InvoiceWritePdf(invoiceid);
        }
        public string InvoiceNameSurname(int invoiceid)
        {
            return _invoiceDAL.InvoiceNameSurname(invoiceid);
        }
        
    }
}
