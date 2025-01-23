namespace HotelReservationSystem
{
    partial class ReservationInformationForm
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
            Guna.UI2.WinForms.Guna2Button reservationAddBtn;
            Guna.UI2.WinForms.Guna2Button reservationUpdateBtn;
            Guna.UI2.WinForms.Guna2Button reservationDeleteBtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rezervasyonDataGridView = new System.Windows.Forms.DataGridView();
            this.reservation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.roomNoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guestNameComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.selectedStartDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.selectedEndDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.endDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reservationSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.reservationOutBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            reservationAddBtn = new Guna.UI2.WinForms.Guna2Button();
            reservationUpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            reservationDeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationAddBtn
            // 
            reservationAddBtn.BackColor = System.Drawing.Color.Transparent;
            reservationAddBtn.BorderRadius = 25;
            reservationAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            reservationAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            reservationAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            reservationAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            reservationAddBtn.FillColor = System.Drawing.SystemColors.AppWorkspace;
            reservationAddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            reservationAddBtn.ForeColor = System.Drawing.Color.DarkGreen;
            reservationAddBtn.Location = new System.Drawing.Point(26, 503);
            reservationAddBtn.Name = "reservationAddBtn";
            reservationAddBtn.Size = new System.Drawing.Size(195, 53);
            reservationAddBtn.TabIndex = 28;
            reservationAddBtn.Text = "Rezervasyon Ekle";
            reservationAddBtn.Click += new System.EventHandler(this.reservationAddBtn_Click);
            // 
            // reservationUpdateBtn
            // 
            reservationUpdateBtn.BackColor = System.Drawing.Color.Transparent;
            reservationUpdateBtn.BorderRadius = 25;
            reservationUpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            reservationUpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            reservationUpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            reservationUpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            reservationUpdateBtn.FillColor = System.Drawing.SystemColors.AppWorkspace;
            reservationUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            reservationUpdateBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            reservationUpdateBtn.Location = new System.Drawing.Point(379, 503);
            reservationUpdateBtn.Name = "reservationUpdateBtn";
            reservationUpdateBtn.Size = new System.Drawing.Size(214, 53);
            reservationUpdateBtn.TabIndex = 29;
            reservationUpdateBtn.Text = "Rezervasyon Güncelle";
            reservationUpdateBtn.Click += new System.EventHandler(this.reservationUpdateBtn_Click);
            // 
            // reservationDeleteBtn
            // 
            reservationDeleteBtn.BackColor = System.Drawing.Color.Transparent;
            reservationDeleteBtn.BorderRadius = 25;
            reservationDeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            reservationDeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            reservationDeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            reservationDeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            reservationDeleteBtn.FillColor = System.Drawing.SystemColors.AppWorkspace;
            reservationDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            reservationDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            reservationDeleteBtn.Location = new System.Drawing.Point(750, 503);
            reservationDeleteBtn.Name = "reservationDeleteBtn";
            reservationDeleteBtn.Size = new System.Drawing.Size(203, 53);
            reservationDeleteBtn.TabIndex = 30;
            reservationDeleteBtn.Text = "Rezervasyon Sil";
            reservationDeleteBtn.Click += new System.EventHandler(this.reservationDeleteBtn_Click);
            // 
            // rezervasyonDataGridView
            // 
            this.rezervasyonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rezervasyonDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.rezervasyonDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(66)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezervasyonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rezervasyonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervasyonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservation_id,
            this.roomNo,
            this.guestNameSurname,
            this.startDate,
            this.endDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rezervasyonDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.rezervasyonDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rezervasyonDataGridView.Location = new System.Drawing.Point(12, 77);
            this.rezervasyonDataGridView.Name = "rezervasyonDataGridView";
            this.rezervasyonDataGridView.Size = new System.Drawing.Size(955, 319);
            this.rezervasyonDataGridView.TabIndex = 18;
            this.rezervasyonDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rezervasyonDataGridView_CellMouseClick);
            // 
            // reservation_id
            // 
            this.reservation_id.DataPropertyName = "reservation_id";
            this.reservation_id.HeaderText = "Rezervasyon Id";
            this.reservation_id.Name = "reservation_id";
            // 
            // roomNo
            // 
            this.roomNo.DataPropertyName = "roomNo";
            this.roomNo.HeaderText = "Oda Numarası";
            this.roomNo.Name = "roomNo";
            // 
            // guestNameSurname
            // 
            this.guestNameSurname.DataPropertyName = "guestNameSurname";
            this.guestNameSurname.HeaderText = "Misafir Adı";
            this.guestNameSurname.Name = "guestNameSurname";
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "startDate";
            this.startDate.HeaderText = "Başlangıç Tarihi";
            this.startDate.Name = "startDate";
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "Bitiş Tarihi";
            this.endDate.Name = "endDate";
            // 
            // startDateTime
            // 
            this.startDateTime.Checked = true;
            this.startDateTime.FillColor = System.Drawing.Color.SkyBlue;
            this.startDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDateTime.Location = new System.Drawing.Point(533, 439);
            this.startDateTime.MaxDate = new System.DateTime(1753, 2, 2, 0, 0, 0, 0);
            this.startDateTime.MinDate = new System.DateTime(1753, 1, 19, 0, 0, 0, 0);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(174, 36);
            this.startDateTime.TabIndex = 35;
            this.startDateTime.Value = new System.DateTime(1753, 1, 19, 0, 0, 0, 0);
            this.startDateTime.ValueChanged += new System.EventHandler(this.startDateTime_ValueChanged);
            // 
            // roomNoComboBox
            // 
            this.roomNoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomNoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomNoComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNoComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNoComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomNoComboBox.ForeColor = System.Drawing.Color.Black;
            this.roomNoComboBox.ItemHeight = 30;
            this.roomNoComboBox.Items.AddRange(new object[] {
            "Lütfen Bir Oda Seçiniz."});
            this.roomNoComboBox.Location = new System.Drawing.Point(35, 439);
            this.roomNoComboBox.Name = "roomNoComboBox";
            this.roomNoComboBox.Size = new System.Drawing.Size(166, 36);
            this.roomNoComboBox.TabIndex = 36;
            this.roomNoComboBox.Click += new System.EventHandler(this.roomNoComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Oda Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(289, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Müşteri Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(529, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(777, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Çıkış Tarihi";
            // 
            // guestNameComboBox
            // 
            this.guestNameComboBox.BackColor = System.Drawing.Color.Transparent;
            this.guestNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guestNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guestNameComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guestNameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guestNameComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guestNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guestNameComboBox.ItemHeight = 30;
            this.guestNameComboBox.Location = new System.Drawing.Point(293, 439);
            this.guestNameComboBox.Name = "guestNameComboBox";
            this.guestNameComboBox.Size = new System.Drawing.Size(167, 36);
            this.guestNameComboBox.TabIndex = 38;
            this.guestNameComboBox.Click += new System.EventHandler(this.guestNameComboBox_Click);
            // 
            // selectedStartDateTimePicker
            // 
            this.selectedStartDateTimePicker.Checked = true;
            this.selectedStartDateTimePicker.FillColor = System.Drawing.Color.SkyBlue;
            this.selectedStartDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectedStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.selectedStartDateTimePicker.Location = new System.Drawing.Point(533, 439);
            this.selectedStartDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.selectedStartDateTimePicker.MinDate = new System.DateTime(1753, 1, 19, 0, 0, 0, 0);
            this.selectedStartDateTimePicker.Name = "selectedStartDateTimePicker";
            this.selectedStartDateTimePicker.Size = new System.Drawing.Size(183, 36);
            this.selectedStartDateTimePicker.TabIndex = 35;
            this.selectedStartDateTimePicker.Value = new System.DateTime(1753, 1, 19, 0, 0, 0, 0);
            this.selectedStartDateTimePicker.Visible = false;
            this.selectedStartDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTime_ValueChanged);
            // 
            // selectedEndDateTimePicker
            // 
            this.selectedEndDateTimePicker.Checked = true;
            this.selectedEndDateTimePicker.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedEndDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectedEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.selectedEndDateTimePicker.Location = new System.Drawing.Point(781, 439);
            this.selectedEndDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.selectedEndDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.selectedEndDateTimePicker.Name = "selectedEndDateTimePicker";
            this.selectedEndDateTimePicker.Size = new System.Drawing.Size(186, 36);
            this.selectedEndDateTimePicker.TabIndex = 35;
            this.selectedEndDateTimePicker.Value = new System.DateTime(2025, 1, 19, 1, 51, 40, 952);
            this.selectedEndDateTimePicker.Visible = false;
            // 
            // endDateTime
            // 
            this.endDateTime.Checked = true;
            this.endDateTime.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.endDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDateTime.Location = new System.Drawing.Point(781, 439);
            this.endDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(186, 36);
            this.endDateTime.TabIndex = 35;
            this.endDateTime.Value = new System.DateTime(2025, 1, 19, 1, 51, 40, 952);
            // 
            // reservationSearch
            // 
            this.reservationSearch.Checked = true;
            this.reservationSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reservationSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reservationSearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.reservationSearch.Location = new System.Drawing.Point(12, 36);
            this.reservationSearch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.reservationSearch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.reservationSearch.Name = "reservationSearch";
            this.reservationSearch.Size = new System.Drawing.Size(226, 27);
            this.reservationSearch.TabIndex = 39;
            this.reservationSearch.Value = new System.DateTime(2025, 1, 21, 21, 29, 39, 190);
            this.reservationSearch.ValueChanged += new System.EventHandler(this.reservationSearch_ValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(157, 18);
            this.guna2HtmlLabel1.TabIndex = 40;
            this.guna2HtmlLabel1.Text = "Rezervasyon Tarihi Aratın";
            // 
            // reservationOutBtn
            // 
            this.reservationOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservationOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservationOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservationOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservationOutBtn.FillColor = System.Drawing.Color.White;
            this.reservationOutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.reservationOutBtn.ForeColor = System.Drawing.Color.Black;
            this.reservationOutBtn.Location = new System.Drawing.Point(244, 33);
            this.reservationOutBtn.Name = "reservationOutBtn";
            this.reservationOutBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.reservationOutBtn.Size = new System.Drawing.Size(30, 30);
            this.reservationOutBtn.TabIndex = 41;
            this.reservationOutBtn.Text = "X";
            this.reservationOutBtn.Click += new System.EventHandler(this.reservationOutBtn_Click);
            // 
            // ReservationInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(996, 588);
            this.Controls.Add(this.reservationOutBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.reservationSearch);
            this.Controls.Add(this.guestNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomNoComboBox);
            this.Controls.Add(this.selectedStartDateTimePicker);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.selectedEndDateTimePicker);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(reservationDeleteBtn);
            this.Controls.Add(reservationUpdateBtn);
            this.Controls.Add(reservationAddBtn);
            this.Controls.Add(this.rezervasyonDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInformationForm";
            this.Text = "ReservationAdForm";
            this.Load += new System.EventHandler(this.ReservationInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView rezervasyonDataGridView;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDateTime;
        private Guna.UI2.WinForms.Guna2ComboBox roomNoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox guestNameComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker selectedStartDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker selectedEndDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDateTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker reservationSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton reservationOutBtn;
    }
}