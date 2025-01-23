using Bunifu.UI.WinForms;
using HotelReservationSystem.DOMAIN;
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

namespace HotelReservationSystem
{
    public partial class ReservationInformationForm : Form
    {
        private Reservation _reservation = new Reservation();
        private ReservationService _reservationService = new ReservationService();

        private  RoomService _roomService = new RoomService();
        private GuestService _guestService = new GuestService();
        private InvoiceService _invoiceService = new InvoiceService();

        public ReservationInformationForm()
        {
            InitializeComponent();
        }

               
        private void reservationUpdateBtn_Click(object sender, EventArgs e)
        {
           
            _reservation.startDate = selectedStartDateTimePicker.Value;
            _reservation.endDate = selectedEndDateTimePicker.Value;
            _reservationService.UpdateReservation(_reservation);

            rezervasyonDataGridView.DataSource = _reservationService.GetDataTable();

        }

        private void ReservationInformationForm_Load(object sender, EventArgs e)
        {

            rezervasyonDataGridView.DataSource = _reservationService.GetDataTable();
            roomNoComboBox.DataSource = _roomService.GetAvailableRoomDataTable();
            roomNoComboBox.DisplayMember = "roomNo";
            roomNoComboBox.ValueMember = "room_id";
            guestNameComboBox.DataSource=_guestService.getGuestNameSurmaneDataTable();
            guestNameComboBox.DisplayMember = "guestNameSurname";
            guestNameComboBox.ValueMember = "guest_id";
            startDateTime.MaxDate = DateTime.Now.AddMonths(4);
            startDateTime.MinDate = DateTime.Now;
        }

        private void startDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime girisTarihi = startDateTime.Value;

            Console.WriteLine(girisTarihi);
            endDateTime.MinDate = girisTarihi.AddDays(1);

            
        }

        private void reservationAddBtn_Click(object sender, EventArgs e)
        {
            _reservation.RoomId = Convert.ToInt32(roomNoComboBox.SelectedValue);
            _reservation.GuestId = Convert.ToInt32(guestNameComboBox.SelectedValue);
            _reservation.startDate = startDateTime.Value;
            _reservation.endDate = endDateTime.Value;
            
            TimeSpan fark = _reservation.endDate.Date - _reservation.startDate.Date;
            decimal _amount = (int)fark.TotalDays * _roomService.GetRoomPrice(_reservation.RoomId);

            _reservationService.AddReservation(_reservation);

            _invoiceService.Add(new Invoice { amount = _amount, reservation_id =_reservationService.GetLastReservationId()});


            rezervasyonDataGridView.DataSource = _reservationService.GetDataTable();
            MessageBox.Show("Rezervasyon Başarıyla Eklendi");

        }
        private void rezervasyonDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            DataGridViewRow selectedRow = rezervasyonDataGridView.SelectedRows[0];
            
            _reservation.ReservationId = Convert.ToInt32(selectedRow.Cells["reservation_id"].Value);
            _reservation.startDate = Convert.ToDateTime(selectedRow.Cells["startDate"].Value);
            _reservation.endDate = Convert.ToDateTime(selectedRow.Cells["endDate"].Value);

            
            roomNoComboBox.DataSource = null;
            guestNameComboBox.DataSource = null;


            roomNoComboBox.Items.Add(Convert.ToInt32(selectedRow.Cells["roomNo"].Value));
            roomNoComboBox.SelectedIndex = 0;

            guestNameComboBox.Items.Add(selectedRow.Cells["guestNameSurname"].Value.ToString());
            guestNameComboBox.SelectedIndex = 0;

            selectedStartDateTimePicker.Visible = true;
            startDateTime.Visible = false;
            selectedStartDateTimePicker.Value= Convert.ToDateTime(selectedRow.Cells["startDate"].Value.ToString());

            selectedEndDateTimePicker.Visible = true;
            endDateTime.Visible = false;
            selectedEndDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["endDate"].Value.ToString());


            Console.WriteLine(_reservation.ReservationId+"/"+_reservation.startDate.Date+"/"+_reservation.endDate.Date+"/"+_reservation.GuestId+"        aaaaaaaaaaaaaaaaaaaaaa");

        }

        private void reservationDeleteBtn_Click(object sender, EventArgs e)
        {
                _invoiceService.DeleteInvoiceReservationId(_reservation.ReservationId);
            if (_reservationService.DeleteReservation(_reservation))
            {
                MessageBox.Show("Başarıyla Silindi");
            }
            foreach (DataGridViewRow row in rezervasyonDataGridView.SelectedRows)
            {
               _reservation.ReservationId = Convert.ToInt32(row.Cells[0].Value);
                _reservationService.DeleteReservation(_reservation);
            }

            rezervasyonDataGridView.DataSource = _reservationService.GetDataTable();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in rezervasyonDataGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _reservationService.DeleteReservation(_reservation);
            }
            this.Refresh();
        }

        private void roomNoComboBox_Click(object sender, EventArgs e)
        {
            roomNoComboBox.DataSource = _roomService.GetAvailableRoomDataTable();
            roomNoComboBox.DisplayMember = "roomNo";
            roomNoComboBox.ValueMember = "room_id";
        }

        private void guestNameComboBox_Click(object sender, EventArgs e)
        {
            guestNameComboBox.DataSource = _guestService.getGuestNameSurmaneDataTable();
            guestNameComboBox.DisplayMember = "guestNameSurname";
            guestNameComboBox.ValueMember = "guest_id";
        }

       

        private void reservationSearch_ValueChanged(object sender, EventArgs e)
        {
            DateTime filter = reservationSearch.Value.Date; // Seçilen tarihi al
            Console.WriteLine(filter); // Konsola yazdır, kontrol için

            DataView dv = _reservationService.GetDataTable().DefaultView;

            // RowFilter ifadesi
            dv.RowFilter = $"StartDate >= '#{filter:yyyy-MM-dd}#' AND StartDate <= '#{filter:yyyy-MM-dd}#'";

            // DataGridView'e filtrelenmiş veriyi bağla
            rezervasyonDataGridView.DataSource = dv;

        }

        private void reservationOutBtn_Click(object sender, EventArgs e)
        {

            rezervasyonDataGridView.DataSource = _reservationService.GetDataTable();
        }
    }
}
