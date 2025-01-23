namespace HotelReservationSystem
{
    partial class InvoiceInformationForm
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
            this.InvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.invoicesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.invoiceSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.invoiceOutBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceDataGridView
            // 
            this.InvoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoicesID,
            this.guestNameSurname,
            this.amount,
            this.invoiceDate});
            this.InvoiceDataGridView.Location = new System.Drawing.Point(22, 75);
            this.InvoiceDataGridView.Name = "InvoiceDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceDataGridView.Size = new System.Drawing.Size(960, 424);
            this.InvoiceDataGridView.TabIndex = 3;
            this.InvoiceDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InvoiceDataGridView_CellMouseClick);
            // 
            // invoicesID
            // 
            this.invoicesID.DataPropertyName = "invoicesID";
            this.invoicesID.HeaderText = "Fatura ID";
            this.invoicesID.Name = "invoicesID";
            // 
            // guestNameSurname
            // 
            this.guestNameSurname.DataPropertyName = "guestNameSurname";
            this.guestNameSurname.HeaderText = "Ad Soyad";
            this.guestNameSurname.Name = "guestNameSurname";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Fiyat";
            this.amount.Name = "amount";
            // 
            // invoiceDate
            // 
            this.invoiceDate.DataPropertyName = "invoiceDate";
            this.invoiceDate.HeaderText = "Fatura Kesim Tarihi";
            this.invoiceDate.Name = "invoiceDate";
            // 
            // invoicePrintBtn
            // 
            this.invoicePrintBtn.BorderRadius = 20;
            this.invoicePrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoicePrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoicePrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoicePrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoicePrintBtn.FillColor = System.Drawing.Color.BlueViolet;
            this.invoicePrintBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.invoicePrintBtn.ForeColor = System.Drawing.Color.White;
            this.invoicePrintBtn.Location = new System.Drawing.Point(782, 515);
            this.invoicePrintBtn.Name = "invoicePrintBtn";
            this.invoicePrintBtn.Size = new System.Drawing.Size(200, 53);
            this.invoicePrintBtn.TabIndex = 4;
            this.invoicePrintBtn.Text = "Faturayı Yazdır";
            this.invoicePrintBtn.Click += new System.EventHandler(this.invoicePrintBtn_Click);
            // 
            // invoiceSearch
            // 
            this.invoiceSearch.Checked = true;
            this.invoiceSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.invoiceSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invoiceSearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.invoiceSearch.Location = new System.Drawing.Point(22, 32);
            this.invoiceSearch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.invoiceSearch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.invoiceSearch.Name = "invoiceSearch";
            this.invoiceSearch.Size = new System.Drawing.Size(226, 27);
            this.invoiceSearch.TabIndex = 40;
            this.invoiceSearch.Value = new System.DateTime(2025, 1, 21, 21, 29, 39, 190);
            this.invoiceSearch.ValueChanged += new System.EventHandler(this.invoiceSearch_ValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(155, 18);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Fatura Kesim Tarihi Aratın";
            // 
            // invoiceOutBtn
            // 
            this.invoiceOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoiceOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoiceOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoiceOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoiceOutBtn.FillColor = System.Drawing.Color.White;
            this.invoiceOutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.invoiceOutBtn.ForeColor = System.Drawing.Color.Black;
            this.invoiceOutBtn.Location = new System.Drawing.Point(254, 32);
            this.invoiceOutBtn.Name = "invoiceOutBtn";
            this.invoiceOutBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.invoiceOutBtn.Size = new System.Drawing.Size(30, 30);
            this.invoiceOutBtn.TabIndex = 42;
            this.invoiceOutBtn.Text = "X";
            this.invoiceOutBtn.Click += new System.EventHandler(this.invoiceOutBtn_Click);
            // 
            // InvoiceInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1019, 580);
            this.Controls.Add(this.invoiceOutBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.invoiceSearch);
            this.Controls.Add(this.invoicePrintBtn);
            this.Controls.Add(this.InvoiceDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaInformationForm";
            this.Load += new System.EventHandler(this.InvoiceInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView InvoiceDataGridView;
        private Guna.UI2.WinForms.Guna2Button invoicePrintBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker invoiceSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton invoiceOutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDate;
    }
}