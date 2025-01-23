using HotelReservationSystem.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.DAL
{
    public class InvoiceDAL
    {
        dbBaglanti db = new dbBaglanti();
        List<decimal> _monthlyEarnings = new List<decimal>();
        public void Add(Invoice invoice) 
        {
            string query = "INSERT INTO TblInvoice(`reservation_id`, `amount`) VALUES ("+invoice.reservation_id+","+invoice.amount+")";
             MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
             command.ExecuteNonQuery();
        }
        public void DeleteInvoiceReservationId(int reservationid) 
        {
            string query = "DELETE FROM TblInvoice WHERE reservation_id =" + reservationid;
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            command.ExecuteNonQuery();
        }
        public DataTable GetDataTable()
        {
            string query = "SELECT invoicesID,TblGuest.guestNameSurname,amount,invoiceDate FROM TblInvoice INNER JOIN TblReservation ON TblInvoice.reservation_id=TblReservation.reservation_id INNER JOIN TblGuest on TblGuest.guest_id=TblReservation.guest_id";
            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
            //MysqlCommand ile sorgumuzu çalıştırıyoruz.DataAdapter ile çalıştırdığımız sorgudan gelen verileri data tableye aktarıyoruz.

        }

        public List<decimal> MonthlyEarning()
        {
            string query = "SELECT YEAR(`invoiceDate`) AS yil,MONTH(`invoiceDate`) AS ay,SUM(`amount`) AS toplam_fiyat FROM  TblInvoice GROUP BY YEAR(`invoiceDate`), MONTH(`invoiceDate`)ORDER BY yil, ay;";
            MySqlDataReader reader = new MySqlCommand(query, db.baglantiGetir()).ExecuteReader();
            while (reader.Read()) 
            {
               // Console.WriteLine(reader[2].ToString());
                _monthlyEarnings.Add(Convert.ToDecimal(reader[2]));
            }
            return _monthlyEarnings;
        }
        public DataTable InvoiceWritePdf(int invoiceid) 
        {
            string query = "SELECT invoicesID, amount, invoiceDate, TblGuest.guestNameSurname FROM TblInvoice JOIN TblReservation ON TblInvoice.reservation_id =TblReservation.reservation_id JOIN TblGuest ON TblReservation.guest_id = TblGuest.guest_id WHERE invoicesID="+invoiceid;

            MySqlCommand command = new MySqlCommand(query, db.baglantiGetir());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
        public string InvoiceNameSurname(int invoiceid) 
        {
            string query = "SELECT TblGuest.guestNameSurname FROM TblInvoice JOIN TblReservation ON TblInvoice.reservation_id =TblReservation.reservation_id JOIN TblGuest ON TblReservation.guest_id = TblGuest.guest_id WHERE invoicesID="+invoiceid;
            MySqlDataReader reader = new MySqlCommand(query, db.baglantiGetir()).ExecuteReader();
            while (reader.Read())
            {
                // Console.WriteLine(reader[2].ToString());
               
            return reader[0].ToString()+".pdf";
            }
            return null;
        }
    }
}
