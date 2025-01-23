using HotelReservationSystem.DAL;
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
    public partial class RoomInformationForm : Form
    {
        private RoomService _roomService = new RoomService();
        Room _room = new Room();
        public RoomInformationForm()
        {
            InitializeComponent();
        }

        private void RoomInformationForm_Load(object sender, EventArgs e)
        {
            roomInformationDataGridView.DataSource= _roomService.GetDataTable();

        }

        private void roomInformationDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in roomInformationDataGridView.Rows)
            {
                bool isAvailable = Convert.ToBoolean(row.Cells[4].Value);

                if (isAvailable) 
                { 
                    row.DefaultCellStyle.BackColor=Color.SeaGreen;
                }
                else 
                {
                    row.DefaultCellStyle.BackColor = Color.Tomato;
                    row.DefaultCellStyle.ForeColor=Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btn_RoomUpdate_Click(object sender, EventArgs e)
        {
            
            _room.roomNo = Convert.ToInt32(txtbx_roomNo.Text);
            _room.roomType = txtbx_roomType.Text;
            _room.price = Convert.ToInt32(txtbx_roomPrice.Text);
            _roomService.Update(_room);
            roomInformationDataGridView.DataSource = _roomService.GetDataTable();
        }

        private void btn_roomAdd_Click_1(object sender, EventArgs e)
        {
            _room.roomNo = Convert.ToInt32(txtbx_roomNo.Text);
            _room.roomType = txtbx_roomType.Text;
            _room.price = Convert.ToInt32(txtbx_roomPrice.Text);
            _roomService.Add(_room);
            roomInformationDataGridView.DataSource = _roomService.GetDataTable();
            MessageBox.Show("Oda no: "+_room.roomNo+"\nOda Tipi: "+_room.roomType+"\nOda Fiyatı: "+_room.price+"\n\tBaşarıyla eklendi");
        }

        private void btn_RoomDelete_Click(object sender, EventArgs e)
        {
            _roomService.Delete(_room.roomID);
            roomInformationDataGridView.DataSource = _roomService.GetDataTable();
        }


        private void roomInformationDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = roomInformationDataGridView.SelectedRows[0];
                _room.roomID = Convert.ToInt32(selectedRow.Cells["room_id"].Value);
                _room.roomNo = Convert.ToInt32(selectedRow.Cells["roomNo"].Value);
                _room.roomType = selectedRow.Cells["roomType"].Value.ToString();
                _room.price = Convert.ToInt32(selectedRow.Cells["price"].Value);
            }
            catch (Exception)
            {

              
            }
            txtbx_roomNo.Text = _room.roomNo.ToString();
            txtbx_roomType.Text = _room.roomType;
            txtbx_roomPrice.Text = _room.price.ToString();
        }


        private void searchRoomBtn_TextChanged(object sender, EventArgs e)
        {
            string filter = searchRoomBtn.Text;
            DataView dv = _roomService.GetDataTable().DefaultView;
            dv.RowFilter = $"roomNo LIKE '%{filter}%'";
            roomInformationDataGridView.DataSource = dv;
        }
    }
}
