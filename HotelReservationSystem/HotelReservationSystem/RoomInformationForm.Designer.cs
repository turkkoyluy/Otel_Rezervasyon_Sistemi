namespace HotelReservationSystem
{
    partial class RoomInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_roomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_roomType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_roomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_RoomUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_roomAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_RoomDelete = new Guna.UI2.WinForms.Guna2Button();
            this.searchRoomBtn = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomInformationDataGridView
            // 
            this.roomInformationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomInformationDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomInformationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomInformationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_id,
            this.roomNo,
            this.roomType,
            this.price,
            this.isAvailable});
            this.roomInformationDataGridView.GridColor = System.Drawing.Color.Black;
            this.roomInformationDataGridView.Location = new System.Drawing.Point(12, 66);
            this.roomInformationDataGridView.Name = "roomInformationDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomInformationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomInformationDataGridView.Size = new System.Drawing.Size(967, 354);
            this.roomInformationDataGridView.TabIndex = 0;
            this.roomInformationDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.roomInformationDataGridView_CellFormatting);
            this.roomInformationDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roomInformationDataGridView_CellMouseClick);
            // 
            // room_id
            // 
            this.room_id.DataPropertyName = "room_id";
            this.room_id.HeaderText = "Oda Id";
            this.room_id.Name = "room_id";
            // 
            // roomNo
            // 
            this.roomNo.DataPropertyName = "roomNo";
            this.roomNo.HeaderText = "Oda Numarası";
            this.roomNo.Name = "roomNo";
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "roomType";
            this.roomType.HeaderText = "Oda Tipi";
            this.roomType.Name = "roomType";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Oda Fiyatı";
            this.price.Name = "price";
            // 
            // isAvailable
            // 
            this.isAvailable.DataPropertyName = "isAvailable";
            this.isAvailable.HeaderText = "Oda Durumu";
            this.isAvailable.Name = "isAvailable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // txtbx_roomNo
            // 
            this.txtbx_roomNo.BorderColor = System.Drawing.Color.Beige;
            this.txtbx_roomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_roomNo.DefaultText = "";
            this.txtbx_roomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_roomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_roomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_roomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_roomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_roomNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_roomNo.ForeColor = System.Drawing.Color.Black;
            this.txtbx_roomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_roomNo.Location = new System.Drawing.Point(31, 449);
            this.txtbx_roomNo.Name = "txtbx_roomNo";
            this.txtbx_roomNo.PasswordChar = '\0';
            this.txtbx_roomNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbx_roomNo.PlaceholderText = "Oda Numarası";
            this.txtbx_roomNo.SelectedText = "";
            this.txtbx_roomNo.Size = new System.Drawing.Size(213, 38);
            this.txtbx_roomNo.TabIndex = 13;
            // 
            // txtbx_roomType
            // 
            this.txtbx_roomType.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtbx_roomType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_roomType.DefaultText = "";
            this.txtbx_roomType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_roomType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_roomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_roomType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_roomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_roomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_roomType.ForeColor = System.Drawing.Color.Black;
            this.txtbx_roomType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_roomType.Location = new System.Drawing.Point(379, 449);
            this.txtbx_roomType.Name = "txtbx_roomType";
            this.txtbx_roomType.PasswordChar = '\0';
            this.txtbx_roomType.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbx_roomType.PlaceholderText = "Oda Tipi";
            this.txtbx_roomType.SelectedText = "";
            this.txtbx_roomType.Size = new System.Drawing.Size(229, 38);
            this.txtbx_roomType.TabIndex = 14;
            // 
            // txtbx_roomPrice
            // 
            this.txtbx_roomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_roomPrice.DefaultText = "";
            this.txtbx_roomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_roomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_roomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_roomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_roomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_roomPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_roomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtbx_roomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_roomPrice.Location = new System.Drawing.Point(728, 449);
            this.txtbx_roomPrice.Name = "txtbx_roomPrice";
            this.txtbx_roomPrice.PasswordChar = '\0';
            this.txtbx_roomPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbx_roomPrice.PlaceholderText = "Oda Fiyatı";
            this.txtbx_roomPrice.SelectedText = "";
            this.txtbx_roomPrice.Size = new System.Drawing.Size(228, 38);
            this.txtbx_roomPrice.TabIndex = 14;
            // 
            // btn_RoomUpdate
            // 
            this.btn_RoomUpdate.BorderRadius = 15;
            this.btn_RoomUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_RoomUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_RoomUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_RoomUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_RoomUpdate.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_RoomUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RoomUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_RoomUpdate.Location = new System.Drawing.Point(31, 502);
            this.btn_RoomUpdate.Name = "btn_RoomUpdate";
            this.btn_RoomUpdate.Size = new System.Drawing.Size(191, 52);
            this.btn_RoomUpdate.TabIndex = 15;
            this.btn_RoomUpdate.Text = "Oda Güncelle";
            this.btn_RoomUpdate.Click += new System.EventHandler(this.btn_RoomUpdate_Click);
            // 
            // btn_roomAdd
            // 
            this.btn_roomAdd.BorderRadius = 15;
            this.btn_roomAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_roomAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_roomAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_roomAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_roomAdd.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_roomAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_roomAdd.ForeColor = System.Drawing.Color.Green;
            this.btn_roomAdd.Location = new System.Drawing.Point(407, 502);
            this.btn_roomAdd.Name = "btn_roomAdd";
            this.btn_roomAdd.Size = new System.Drawing.Size(190, 52);
            this.btn_roomAdd.TabIndex = 15;
            this.btn_roomAdd.Text = "Oda Ekle";
            this.btn_roomAdd.Click += new System.EventHandler(this.btn_roomAdd_Click_1);
            // 
            // btn_RoomDelete
            // 
            this.btn_RoomDelete.BorderRadius = 15;
            this.btn_RoomDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_RoomDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_RoomDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_RoomDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_RoomDelete.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_RoomDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RoomDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_RoomDelete.Location = new System.Drawing.Point(775, 502);
            this.btn_RoomDelete.Name = "btn_RoomDelete";
            this.btn_RoomDelete.Size = new System.Drawing.Size(196, 52);
            this.btn_RoomDelete.TabIndex = 15;
            this.btn_RoomDelete.Text = "Oda Sil";
            this.btn_RoomDelete.Click += new System.EventHandler(this.btn_RoomDelete_Click);
            // 
            // searchRoomBtn
            // 
            this.searchRoomBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchRoomBtn.DefaultText = "";
            this.searchRoomBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchRoomBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchRoomBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchRoomBtn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchRoomBtn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchRoomBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchRoomBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchRoomBtn.Location = new System.Drawing.Point(12, 12);
            this.searchRoomBtn.Name = "searchRoomBtn";
            this.searchRoomBtn.PasswordChar = '\0';
            this.searchRoomBtn.PlaceholderText = "Oda Numarasını Aratın";
            this.searchRoomBtn.SelectedText = "";
            this.searchRoomBtn.Size = new System.Drawing.Size(284, 36);
            this.searchRoomBtn.TabIndex = 16;
            this.searchRoomBtn.TextChanged += new System.EventHandler(this.searchRoomBtn_TextChanged);
            // 
            // RoomInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1001, 578);
            this.Controls.Add(this.searchRoomBtn);
            this.Controls.Add(this.btn_RoomDelete);
            this.Controls.Add(this.btn_roomAdd);
            this.Controls.Add(this.btn_RoomUpdate);
            this.Controls.Add(this.txtbx_roomPrice);
            this.Controls.Add(this.txtbx_roomType);
            this.Controls.Add(this.txtbx_roomNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomInformationDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInformationForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.RoomInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomInformationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailable;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_roomNo;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_roomType;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_roomPrice;
        private Guna.UI2.WinForms.Guna2Button btn_RoomUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_roomAdd;
        private Guna.UI2.WinForms.Guna2Button btn_RoomDelete;
        private Guna.UI2.WinForms.Guna2TextBox searchRoomBtn;
    }
}