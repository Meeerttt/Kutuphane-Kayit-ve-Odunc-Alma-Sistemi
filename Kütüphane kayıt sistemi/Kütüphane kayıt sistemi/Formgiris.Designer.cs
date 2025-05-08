namespace Kütüphane_kayıt_sistemi
{
    partial class Formgiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgiris));
            this.Kullanıcı_textbox = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Kullaniciadı_txt = new System.Windows.Forms.Label();
            this.pbGosterGizle = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.Kütüphane = new System.Windows.Forms.Label();
            this.Kayıtol = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kullanıcı_textbox
            // 
            this.Kullanıcı_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanıcı_textbox.Location = new System.Drawing.Point(531, 209);
            this.Kullanıcı_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanıcı_textbox.Name = "Kullanıcı_textbox";
            this.Kullanıcı_textbox.Size = new System.Drawing.Size(172, 30);
            this.Kullanıcı_textbox.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(531, 266);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(172, 30);
            this.txtSifre.TabIndex = 5;
            // 
            // Kullaniciadı_txt
            // 
            this.Kullaniciadı_txt.AutoSize = true;
            this.Kullaniciadı_txt.BackColor = System.Drawing.Color.Transparent;
            this.Kullaniciadı_txt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullaniciadı_txt.ForeColor = System.Drawing.Color.White;
            this.Kullaniciadı_txt.Location = new System.Drawing.Point(253, 201);
            this.Kullaniciadı_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kullaniciadı_txt.Name = "Kullaniciadı_txt";
            this.Kullaniciadı_txt.Size = new System.Drawing.Size(194, 37);
            this.Kullaniciadı_txt.TabIndex = 6;
            this.Kullaniciadı_txt.Text = "Kullanıcı adı";
            // 
            // pbGosterGizle
            // 
            this.pbGosterGizle.BackColor = System.Drawing.Color.Transparent;
            this.pbGosterGizle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pbGosterGizle.ForeColor = System.Drawing.Color.White;
            this.pbGosterGizle.Location = new System.Drawing.Point(253, 258);
            this.pbGosterGizle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pbGosterGizle.Name = "pbGosterGizle";
            this.pbGosterGizle.Size = new System.Drawing.Size(136, 48);
            this.pbGosterGizle.TabIndex = 7;
            this.pbGosterGizle.Text = "Şifre";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(604, 342);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(99, 44);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Kütüphane
            // 
            this.Kütüphane.BackColor = System.Drawing.Color.Transparent;
            this.Kütüphane.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kütüphane.ForeColor = System.Drawing.Color.White;
            this.Kütüphane.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Kütüphane.Location = new System.Drawing.Point(73, 81);
            this.Kütüphane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kütüphane.Name = "Kütüphane";
            this.Kütüphane.Size = new System.Drawing.Size(829, 91);
            this.Kütüphane.TabIndex = 0;
            this.Kütüphane.Text = "KÜTÜPHANEMİZE HOŞGELDİNİZ";
            this.Kütüphane.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Kayıtol
            // 
            this.Kayıtol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtol.Location = new System.Drawing.Point(260, 342);
            this.Kayıtol.Margin = new System.Windows.Forms.Padding(4);
            this.Kayıtol.Name = "Kayıtol";
            this.Kayıtol.Size = new System.Drawing.Size(124, 44);
            this.Kayıtol.TabIndex = 9;
            this.Kayıtol.Text = "Kayıt ol";
            this.Kayıtol.UseVisualStyleBackColor = true;
            this.Kayıtol.Click += new System.EventHandler(this.Kayıtol_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.pbGosterGizle);
            this.panelLogin.Controls.Add(this.btnGiris);
            this.panelLogin.Controls.Add(this.Kullaniciadı_txt);
            this.panelLogin.Controls.Add(this.Kayıtol);
            this.panelLogin.Controls.Add(this.Kütüphane);
            this.panelLogin.Controls.Add(this.Kullanıcı_textbox);
            this.panelLogin.Controls.Add(this.txtSifre);
            this.panelLogin.Location = new System.Drawing.Point(77, 53);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(940, 544);
            this.panelLogin.TabIndex = 10;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // Formgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGiris;
            this.ClientSize = new System.Drawing.Size(1151, 735);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formgiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Kullanıcı_textbox;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label Kullaniciadı_txt;
        private System.Windows.Forms.Label pbGosterGizle;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label Kütüphane;
        private System.Windows.Forms.Button Kayıtol;
        private System.Windows.Forms.Panel panelLogin;
    }
}

