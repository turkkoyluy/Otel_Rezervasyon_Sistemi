using HotelReservationSystem.DOMAIN;
using HotelReservationSystem.SERVICES;
using Mysqlx.Crud;
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
    public partial class MainForm : Form
    {
     

        private readonly RoomService roomService = new RoomService();
        private readonly ReservationService reservationService = new ReservationService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            this.panelload.Controls.Clear();
            HomePageForm formMain = new HomePageForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panelload.Controls.Add(formMain);
            formMain.Show();


        }


        private void progressBar1_Click(object sender, EventArgs e)
        {
            RoomInformationForm roominformationform = new RoomInformationForm();
            roominformationform.Show();
            this.Close();
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
           // reservationService.AddReservation(new DOMAIN.Reservation {RoomNo=Convert.ToInt32(textBox1.Text),new Customer {NameSurname= } });
        }


        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            anasayfaBtn.BackColor = Color.AliceBlue;
            labelTitle.Text = "Ana Sayfa";
            this.panelload.Controls.Clear();
            HomePageForm formMain = new HomePageForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panelload.Controls.Add(formMain);
            formMain.Show();


        }

        private void odaBtn_Click(object sender, EventArgs e)
        {
            
            labelTitle.Text = "ODA İŞLEMLERİ";
            this.panelload.Controls.Clear();
            RoomInformationForm roomInformationForm = new RoomInformationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            roomInformationForm.FormBorderStyle = FormBorderStyle.None;
            this.panelload.Controls.Add(roomInformationForm);
            roomInformationForm.Show();
        }

        private void rezervasyonBtn_Click(object sender, EventArgs e)
        {
            
            labelTitle.Text = "REZERVASYON";
            this.panelload.Controls.Clear();
            ReservationInformationForm reservationAdForm = new ReservationInformationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            reservationAdForm.FormBorderStyle = FormBorderStyle.None;
            this.panelload.Controls.Add(reservationAdForm);
            reservationAdForm.Show();

        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void misafirBtn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "MİSAFİR";
            this.panelload.Controls.Clear();
            GuestInformationForm musteri = new GuestInformationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            musteri.FormBorderStyle = FormBorderStyle.None;
            this.panelload.Controls.Add(musteri);
            musteri.Show();
        }

        private void anasayfaBtn_Leave(object sender, EventArgs e)
        {
            anasayfaBtn.BackColor = Color.LightGray;
        }

        private void Fatura_btn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "FATURA";
            this.panelload.Controls.Clear();
            InvoiceInformationForm faturaInformationForm = new InvoiceInformationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            faturaInformationForm.FormBorderStyle = FormBorderStyle.None;
            this.panelload.Controls.Add(faturaInformationForm);
            faturaInformationForm.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
