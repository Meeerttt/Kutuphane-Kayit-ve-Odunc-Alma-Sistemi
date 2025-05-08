
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Kütüphane_kayıt_sistemi
{

    public partial class Formgiris: Form

    {
        public Formgiris()
        {
            InitializeComponent();
        }
       
        public static int girisYapanKullaniciID;
        public static string girisYapanKullaniciAdi;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
            panelLogin.Anchor = AnchorStyles.None;  


        }
      

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = Kullanıcı_textbox.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            string baglantiMetni = "Host=localhost;Port=5432;Username=postgres;Password=mert2004;Database=Kutuphane_db";
            using (NpgsqlConnection baglanti = new NpgsqlConnection(baglantiMetni))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT * FROM kullanıcılar WHERE kullaniciadi = @kadi AND sifre = @sifre";
                    using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", sifre);

                        using (NpgsqlDataReader dr = komut.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                girisYapanKullaniciID = Convert.ToInt32(dr["kullaniciid"]);

                                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FormMain.girisYapanKullaniciAdi = kullaniciAdi; 
                                FormMain formMain = new FormMain();
                                formMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Kayıtol_Click(object sender, EventArgs e)
        {
 
            Formkayıt form2 = new Formkayıt();
            form2.Show(); 
            this.Hide(); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
