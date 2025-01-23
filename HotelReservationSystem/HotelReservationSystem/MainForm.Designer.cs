namespace HotelReservationSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rezervasyonBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.Fatura_btn = new System.Windows.Forms.Button();
            this.misafirBtn = new System.Windows.Forms.Button();
            this.odaBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.panelload = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rezervasyonBtn);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.Fatura_btn);
            this.panel1.Controls.Add(this.misafirBtn);
            this.panel1.Controls.Add(this.odaBtn);
            this.panel1.Controls.Add(this.anasayfaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 675);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rezervasyonBtn
            // 
            this.rezervasyonBtn.FlatAppearance.BorderSize = 0;
            this.rezervasyonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rezervasyonBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonBtn.Image = ((System.Drawing.Image)(resources.GetObject("rezervasyonBtn.Image")));
            this.rezervasyonBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rezervasyonBtn.Location = new System.Drawing.Point(-5, 397);
            this.rezervasyonBtn.Name = "rezervasyonBtn";
            this.rezervasyonBtn.Size = new System.Drawing.Size(178, 62);
            this.rezervasyonBtn.TabIndex = 1;
            this.rezervasyonBtn.Text = "Rezervasyon";
            this.rezervasyonBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rezervasyonBtn.UseVisualStyleBackColor = true;
            this.rezervasyonBtn.Click += new System.EventHandler(this.rezervasyonBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.FlatAppearance.BorderSize = 0;
            this.cikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBtn.Image = ((System.Drawing.Image)(resources.GetObject("cikisBtn.Image")));
            this.cikisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cikisBtn.Location = new System.Drawing.Point(-2, 599);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(178, 55);
            this.cikisBtn.TabIndex = 1;
            this.cikisBtn.Text = "Çıkış Yap";
            this.cikisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // Fatura_btn
            // 
            this.Fatura_btn.FlatAppearance.BorderSize = 0;
            this.Fatura_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fatura_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fatura_btn.Image = global::HotelReservationSystem.Properties.Resources.invoice_6296099;
            this.Fatura_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Fatura_btn.Location = new System.Drawing.Point(-2, 478);
            this.Fatura_btn.Name = "Fatura_btn";
            this.Fatura_btn.Size = new System.Drawing.Size(178, 61);
            this.Fatura_btn.TabIndex = 1;
            this.Fatura_btn.Text = "Faturalar";
            this.Fatura_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Fatura_btn.UseVisualStyleBackColor = true;
            this.Fatura_btn.Click += new System.EventHandler(this.Fatura_btn_Click);
            // 
            // misafirBtn
            // 
            this.misafirBtn.FlatAppearance.BorderSize = 0;
            this.misafirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.misafirBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.misafirBtn.Image = ((System.Drawing.Image)(resources.GetObject("misafirBtn.Image")));
            this.misafirBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.misafirBtn.Location = new System.Drawing.Point(-2, 320);
            this.misafirBtn.Name = "misafirBtn";
            this.misafirBtn.Size = new System.Drawing.Size(175, 60);
            this.misafirBtn.TabIndex = 1;
            this.misafirBtn.Text = "Misafir";
            this.misafirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.misafirBtn.UseVisualStyleBackColor = true;
            this.misafirBtn.Click += new System.EventHandler(this.misafirBtn_Click);
            // 
            // odaBtn
            // 
            this.odaBtn.FlatAppearance.BorderSize = 0;
            this.odaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaBtn.Image = ((System.Drawing.Image)(resources.GetObject("odaBtn.Image")));
            this.odaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odaBtn.Location = new System.Drawing.Point(-10, 235);
            this.odaBtn.Name = "odaBtn";
            this.odaBtn.Size = new System.Drawing.Size(183, 65);
            this.odaBtn.TabIndex = 1;
            this.odaBtn.Text = "Oda İşlemleri";
            this.odaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.odaBtn.UseVisualStyleBackColor = true;
            this.odaBtn.Click += new System.EventHandler(this.odaBtn_Click);
            // 
            // anasayfaBtn
            // 
            this.anasayfaBtn.FlatAppearance.BorderSize = 0;
            this.anasayfaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("anasayfaBtn.Image")));
            this.anasayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.anasayfaBtn.Location = new System.Drawing.Point(-12, 159);
            this.anasayfaBtn.Name = "anasayfaBtn";
            this.anasayfaBtn.Size = new System.Drawing.Size(187, 60);
            this.anasayfaBtn.TabIndex = 1;
            this.anasayfaBtn.Text = "Ana Sayfa";
            this.anasayfaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.anasayfaBtn.UseVisualStyleBackColor = true;
            this.anasayfaBtn.Click += new System.EventHandler(this.anasayfaBtn_Click);
            this.anasayfaBtn.Leave += new System.EventHandler(this.anasayfaBtn_Leave);
            // 
            // panelload
            // 
            this.panelload.BackColor = System.Drawing.Color.White;
            this.panelload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelload.Location = new System.Drawing.Point(173, 92);
            this.panelload.Name = "panelload";
            this.panelload.Size = new System.Drawing.Size(992, 583);
            this.panelload.TabIndex = 19;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(185, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(116, 37);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "AnaSayfa";
            // 
            // closebtn
            // 
            this.closebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closebtn.FillColor = System.Drawing.Color.White;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.closebtn.ForeColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(1123, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closebtn.Size = new System.Drawing.Size(30, 30);
            this.closebtn.TabIndex = 42;
            this.closebtn.Text = "X";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 675);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelload);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button rezervasyonBtn;
        private System.Windows.Forms.Button misafirBtn;
        private System.Windows.Forms.Button odaBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Panel panelload;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Fatura_btn;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
    }
}