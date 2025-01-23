using HotelReservationSystem.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HotelReservationSystem
{
    public partial class HomePageForm : Form
    {
        private  RoomService _roomService = new RoomService();
        private  ReservationService _reservationService = new ReservationService();
        private InvoiceService _invoiceService = new InvoiceService();
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlfile = new XmlDocument();
            xmlfile.Load(today);

            
           
            kurDataGridView.Rows[0].Cells[0].Value = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml.ToString();
            kurDataGridView.Rows[0].Cells[1].Value = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml.ToString();
            kurDataGridView.Rows[0].Cells[2].Value = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml.ToString(); 
            kurDataGridView.Rows[0].Cells[3].Value = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml.ToString();


            int allroom = _roomService.RoomCount("Select Count(*) From TblRoom");
            int isntroom = _roomService.RoomCount("Select Count(*) From TblRoom Where isAvailable=0")*100;
            Console.WriteLine(allroom+"/"+isntroom);
            Console.WriteLine(isntroom/allroom);
            circularProgressBar1.Text = "%"+(isntroom/allroom).ToString();


           /*earningsChart.Series["Kazanç"].Points[0].SetValueY(100);*/
           int a = _invoiceService.MonthlyEarning().Count;
            
            for (int i = 0; i < a; i++)
            {
                earningsChart.Series["Kazanç"].Points[i].SetValueY(_invoiceService.MonthlyEarning()[i]);
                Console.WriteLine("denemeeee" + _invoiceService.MonthlyEarning()[i]);
            }


        }

    }
}
