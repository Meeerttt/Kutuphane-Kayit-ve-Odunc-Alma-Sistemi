namespace Kütüphane_kayıt_sistemi
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.cmbFiltrele = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgwkitaplar = new System.Windows.Forms.DataGridView();
            this.tabPageProfilim = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.OduncListele = new System.Windows.Forms.Button();
            this.dgwOduncListele = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.Adres_lbl = new System.Windows.Forms.Label();
            this.Tel_lbl = new System.Windows.Forms.Label();
            this.Şifre_lbl = new System.Windows.Forms.Label();
            this.KullanıcıAdı_lbl = new System.Windows.Forms.Label();
            this.Sad_lbl = new System.Windows.Forms.Label();
            this.Ad_lbl = new System.Windows.Forms.Label();
            this.Şifre_txt = new System.Windows.Forms.TextBox();
            this.Adres_txt = new System.Windows.Forms.TextBox();
            this.kullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.Tel_txt = new System.Windows.Forms.TextBox();
            this.Sad_txt = new System.Windows.Forms.TextBox();
            this.Ad_txt = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitaplar)).BeginInit();
            this.tabPageProfilim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOduncListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabcontrol1.Controls.Add(this.tabPage1);
            this.tabcontrol1.Controls.Add(this.tabPageProfilim);
            this.tabcontrol1.HotTrack = true;
            this.tabcontrol1.Location = new System.Drawing.Point(17, 63);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1043, 470);
            this.tabcontrol1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Sienna;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.cmbKategori);
            this.tabPage1.Controls.Add(this.btnOdunc);
            this.tabPage1.Controls.Add(this.btnListele);
            this.tabPage1.Controls.Add(this.cmbFiltrele);
            this.tabPage1.Controls.Add(this.btnAra);
            this.tabPage1.Controls.Add(this.txtAra);
            this.tabPage1.Controls.Add(this.dgwkitaplar);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitaplar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Roman",
            "Bilim Kurgu",
            "Fantastik",
            "Tarih",
            "Biyografi",
            "Kişisel Gelişim",
            "Bilim",
            "Teknoloji",
            "Sanat",
            "Çocuk Kitapları",
            "Hepsi"});
            this.cmbKategori.Location = new System.Drawing.Point(451, 11);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbKategori.TabIndex = 6;
            this.cmbKategori.Text = "Kategoriler";
            // 
            // btnOdunc
            // 
            this.btnOdunc.Location = new System.Drawing.Point(453, 41);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(119, 30);
            this.btnOdunc.TabIndex = 5;
            this.btnOdunc.Text = "Ödünç Al";
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(285, 42);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(131, 30);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cmbFiltrele
            // 
            this.cmbFiltrele.FormattingEnabled = true;
            this.cmbFiltrele.Items.AddRange(new object[] {
            "kitapadi",
            "yazar"});
            this.cmbFiltrele.Location = new System.Drawing.Point(68, 42);
            this.cmbFiltrele.Name = "cmbFiltrele";
            this.cmbFiltrele.Size = new System.Drawing.Size(135, 24);
            this.cmbFiltrele.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(285, 8);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(131, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(68, 11);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(120, 22);
            this.txtAra.TabIndex = 1;
            // 
            // dgwkitaplar
            // 
            this.dgwkitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkitaplar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwkitaplar.Location = new System.Drawing.Point(53, 85);
            this.dgwkitaplar.Name = "dgwkitaplar";
            this.dgwkitaplar.RowHeadersWidth = 51;
            this.dgwkitaplar.RowTemplate.Height = 24;
            this.dgwkitaplar.Size = new System.Drawing.Size(916, 353);
            this.dgwkitaplar.TabIndex = 0;
            this.dgwkitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwkitaplar_CellContentClick);
            // 
            // tabPageProfilim
            // 
            this.tabPageProfilim.BackColor = System.Drawing.Color.Sienna;
            this.tabPageProfilim.Controls.Add(this.pictureBox4);
            this.tabPageProfilim.Controls.Add(this.btnTeslim);
            this.tabPageProfilim.Controls.Add(this.OduncListele);
            this.tabPageProfilim.Controls.Add(this.dgwOduncListele);
            this.tabPageProfilim.Controls.Add(this.pictureBox1);
            this.tabPageProfilim.Controls.Add(this.btnGuncelle);
            this.tabPageProfilim.Controls.Add(this.Adres_lbl);
            this.tabPageProfilim.Controls.Add(this.Tel_lbl);
            this.tabPageProfilim.Controls.Add(this.Şifre_lbl);
            this.tabPageProfilim.Controls.Add(this.KullanıcıAdı_lbl);
            this.tabPageProfilim.Controls.Add(this.Sad_lbl);
            this.tabPageProfilim.Controls.Add(this.Ad_lbl);
            this.tabPageProfilim.Controls.Add(this.Şifre_txt);
            this.tabPageProfilim.Controls.Add(this.Adres_txt);
            this.tabPageProfilim.Controls.Add(this.kullaniciAdi_txt);
            this.tabPageProfilim.Controls.Add(this.Tel_txt);
            this.tabPageProfilim.Controls.Add(this.Sad_txt);
            this.tabPageProfilim.Controls.Add(this.Ad_txt);
            this.tabPageProfilim.Location = new System.Drawing.Point(4, 28);
            this.tabPageProfilim.Name = "tabPageProfilim";
            this.tabPageProfilim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfilim.Size = new System.Drawing.Size(1035, 438);
            this.tabPageProfilim.TabIndex = 1;
            this.tabPageProfilim.Text = "Profilim";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnTeslim
            // 
            this.btnTeslim.Location = new System.Drawing.Point(729, 18);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(148, 47);
            this.btnTeslim.TabIndex = 16;
            this.btnTeslim.Text = "Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = true;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // OduncListele
            // 
            this.OduncListele.Location = new System.Drawing.Point(445, 18);
            this.OduncListele.Name = "OduncListele";
            this.OduncListele.Size = new System.Drawing.Size(146, 47);
            this.OduncListele.TabIndex = 15;
            this.OduncListele.Text = "Ödünç Kitaplarım";
            this.OduncListele.UseVisualStyleBackColor = true;
            this.OduncListele.Click += new System.EventHandler(this.OduncListele_Click);
            // 
            // dgwOduncListele
            // 
            this.dgwOduncListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOduncListele.Location = new System.Drawing.Point(445, 73);
            this.dgwOduncListele.Name = "dgwOduncListele";
            this.dgwOduncListele.RowHeadersWidth = 51;
            this.dgwOduncListele.RowTemplate.Height = 24;
            this.dgwOduncListele.Size = new System.Drawing.Size(528, 312);
            this.dgwOduncListele.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(147, 388);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 41);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Adres_lbl
            // 
            this.Adres_lbl.AutoSize = true;
            this.Adres_lbl.Location = new System.Drawing.Point(89, 343);
            this.Adres_lbl.Name = "Adres_lbl";
            this.Adres_lbl.Size = new System.Drawing.Size(43, 16);
            this.Adres_lbl.TabIndex = 11;
            this.Adres_lbl.Text = "Adres";
            // 
            // Tel_lbl
            // 
            this.Tel_lbl.AutoSize = true;
            this.Tel_lbl.Location = new System.Drawing.Point(89, 294);
            this.Tel_lbl.Name = "Tel_lbl";
            this.Tel_lbl.Size = new System.Drawing.Size(53, 16);
            this.Tel_lbl.TabIndex = 10;
            this.Tel_lbl.Text = "Telefon";
            // 
            // Şifre_lbl
            // 
            this.Şifre_lbl.AutoSize = true;
            this.Şifre_lbl.Location = new System.Drawing.Point(89, 244);
            this.Şifre_lbl.Name = "Şifre_lbl";
            this.Şifre_lbl.Size = new System.Drawing.Size(34, 16);
            this.Şifre_lbl.TabIndex = 9;
            this.Şifre_lbl.Text = "Şifre";
            // 
            // KullanıcıAdı_lbl
            // 
            this.KullanıcıAdı_lbl.AutoSize = true;
            this.KullanıcıAdı_lbl.Location = new System.Drawing.Point(89, 200);
            this.KullanıcıAdı_lbl.Name = "KullanıcıAdı_lbl";
            this.KullanıcıAdı_lbl.Size = new System.Drawing.Size(79, 16);
            this.KullanıcıAdı_lbl.TabIndex = 8;
            this.KullanıcıAdı_lbl.Text = "Kullanıcı Adı";
            // 
            // Sad_lbl
            // 
            this.Sad_lbl.AutoSize = true;
            this.Sad_lbl.Location = new System.Drawing.Point(89, 160);
            this.Sad_lbl.Name = "Sad_lbl";
            this.Sad_lbl.Size = new System.Drawing.Size(47, 16);
            this.Sad_lbl.TabIndex = 7;
            this.Sad_lbl.Text = "Soyad";
            // 
            // Ad_lbl
            // 
            this.Ad_lbl.AutoSize = true;
            this.Ad_lbl.Location = new System.Drawing.Point(89, 118);
            this.Ad_lbl.Name = "Ad_lbl";
            this.Ad_lbl.Size = new System.Drawing.Size(24, 16);
            this.Ad_lbl.TabIndex = 6;
            this.Ad_lbl.Text = "Ad";
            // 
            // Şifre_txt
            // 
            this.Şifre_txt.Location = new System.Drawing.Point(223, 244);
            this.Şifre_txt.Name = "Şifre_txt";
            this.Şifre_txt.Size = new System.Drawing.Size(100, 22);
            this.Şifre_txt.TabIndex = 5;
            // 
            // Adres_txt
            // 
            this.Adres_txt.Location = new System.Drawing.Point(223, 343);
            this.Adres_txt.Name = "Adres_txt";
            this.Adres_txt.Size = new System.Drawing.Size(100, 22);
            this.Adres_txt.TabIndex = 4;
            // 
            // kullaniciAdi_txt
            // 
            this.kullaniciAdi_txt.Location = new System.Drawing.Point(223, 200);
            this.kullaniciAdi_txt.Name = "kullaniciAdi_txt";
            this.kullaniciAdi_txt.Size = new System.Drawing.Size(100, 22);
            this.kullaniciAdi_txt.TabIndex = 3;
            // 
            // Tel_txt
            // 
            this.Tel_txt.Location = new System.Drawing.Point(223, 288);
            this.Tel_txt.Name = "Tel_txt";
            this.Tel_txt.Size = new System.Drawing.Size(100, 22);
            this.Tel_txt.TabIndex = 2;
            // 
            // Sad_txt
            // 
            this.Sad_txt.Location = new System.Drawing.Point(223, 160);
            this.Sad_txt.Name = "Sad_txt";
            this.Sad_txt.Size = new System.Drawing.Size(100, 22);
            this.Sad_txt.TabIndex = 1;
            // 
            // Ad_txt
            // 
            this.Ad_txt.Location = new System.Drawing.Point(223, 112);
            this.Ad_txt.Name = "Ad_txt";
            this.Ad_txt.Size = new System.Drawing.Size(100, 22);
            this.Ad_txt.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.tabcontrol1);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(10, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1084, 575);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 636);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitaplar)).EndInit();
            this.tabPageProfilim.ResumeLayout(false);
            this.tabPageProfilim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOduncListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageProfilim;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgwkitaplar;
        private System.Windows.Forms.ComboBox cmbFiltrele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label Adres_lbl;
        private System.Windows.Forms.Label Tel_lbl;
        private System.Windows.Forms.Label Şifre_lbl;
        private System.Windows.Forms.Label KullanıcıAdı_lbl;
        private System.Windows.Forms.Label Sad_lbl;
        private System.Windows.Forms.Label Ad_lbl;
        private System.Windows.Forms.TextBox Şifre_txt;
        private System.Windows.Forms.TextBox Adres_txt;
        private System.Windows.Forms.TextBox kullaniciAdi_txt;
        private System.Windows.Forms.TextBox Tel_txt;
        private System.Windows.Forms.TextBox Sad_txt;
        private System.Windows.Forms.TextBox Ad_txt;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Button OduncListele;
        private System.Windows.Forms.DataGridView dgwOduncListele;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}