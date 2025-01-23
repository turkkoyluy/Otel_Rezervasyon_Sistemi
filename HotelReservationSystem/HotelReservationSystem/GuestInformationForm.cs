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
    public partial class GuestInformationForm : Form

    {
        Guest _guest=new Guest();
        GuestService _guestService = new GuestService();
        public GuestInformationForm()
        {
            InitializeComponent();
        }

        private void guestadd_btn_Click(object sender, EventArgs e)
        {
            _guest.NameSurname=guestnamesurnameTextBox.Text;
            _guest.Number=guestphoneTextBox.Text;
            _guest.TcNo=guestTcTextBox.Text;
            _guestService.Add(_guest);
            guestDataGridView.DataSource = _guestService.getGuestNameSurmaneDataTable();
            MessageBox.Show("Ad Soyad: " + _guest.NameSurname + "\nTelefon Numarası: " + _guest.Number + "\nKimlik Numarası: " + _guest.TcNo + "\n\tBaşarıyla eklendi");
        }
        private void musteri_Load(object sender, EventArgs e)
        {
            guestDataGridView.DataSource = _guestService.getGuestNameSurmaneDataTable();
        }

        private void guestdelete_btn_Click(object sender, EventArgs e)
        {
            _guestService.Delete(_guest.Id);
            guestDataGridView.DataSource = _guestService.getGuestNameSurmaneDataTable();
        }

        private void guestDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = guestDataGridView.SelectedRows[0];

            _guest.Id = Convert.ToInt32(selectedRow.Cells["guest_id"].Value);
            _guest.NameSurname= selectedRow.Cells["guestNameSurname"].Value.ToString();
            _guest.Number=selectedRow.Cells["guestNumber"].Value.ToString();
            _guest.TcNo= selectedRow.Cells["guestTCNo"].Value.ToString();

            guestnamesurnameTextBox.Text = selectedRow.Cells["guestNameSurname"].Value.ToString();
            guestphoneTextBox.Text = selectedRow.Cells["guestNumber"].Value.ToString();
            guestTcTextBox.Text = selectedRow.Cells["guestTCNo"].Value.ToString();
        }

        private void guestupdate_btn_Click(object sender, EventArgs e)
        {
            _guest.NameSurname = guestnamesurnameTextBox.Text;
            _guest.Number = guestphoneTextBox.Text;
            _guest.TcNo = guestTcTextBox.Text;
            _guestService.Update(_guest);

            guestDataGridView.DataSource = _guestService.getGuestNameSurmaneDataTable();

        }


        private void searchGuestBtn_TextChanged(object sender, EventArgs e)
        {
            string filter = searchGuestBtn.Text;
            DataView dv = _guestService.getGuestNameSurmaneDataTable().DefaultView;
            dv.RowFilter = $"guestNameSurname LIKE '%{filter}%'";
            guestDataGridView.DataSource = dv;
        }
    }
}
