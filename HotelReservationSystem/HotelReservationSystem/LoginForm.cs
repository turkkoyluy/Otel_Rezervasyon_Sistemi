using HotelReservationSystem.DAL;
using HotelReservationSystem.DOMAIN;
using HotelReservationSystem.SERVICES;
using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        private readonly AdminService adminService = new AdminService();
        private readonly RoomService rooomService = new RoomService();
        public static Admin admin;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void girisbutton_Click(object sender, EventArgs e)
        {
            admin = adminService.Login(new Admin {nameSurname= namesurname.Text, mail = mail.Text, password= Convert.ToInt32(password.Text) });//ADmin servis classımızın içindeki Login() fonksiyonunu çağırıyoruz

            if (admin!=null)
            {
                // Hoşgeldiniz mesajı
                MessageBox.Show($"Hoşgeldiniz, {admin.nameSurname}!");

                // Form2'ye geçiş
                MainForm form2 = new MainForm(); // Yeni form nesnesi oluşturulur
                form2.Show(); // Form2 açılır
                this.Hide(); // Form1 gizlenir
            }
            else
            {
                MessageBox.Show("Email veya şifre hatalı.");
            }


        }

    }  
}
