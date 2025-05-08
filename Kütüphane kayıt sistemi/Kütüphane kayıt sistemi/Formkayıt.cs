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
    public partial class Formkayıt : Form
    {
        public Formkayıt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string adres = txtAdres.Text.Trim();

            if (ad == "" || soyad == "" || kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
                return;
            }

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=mert2004;Database=Kutuphane_db";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO kullanıcılar (ad, soyad, kullaniciadi, sifre, telefon, adres) VALUES (@ad, @soyad, @kullaniciadi, @sifre, @telefon, @adres)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@soyad", soyad);
                        cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@adres", adres);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarılı!");

                 
                    this.Hide();
                    Formgiris girisForm = new Formgiris();
                    girisForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Formgiris girisForm = new Formgiris();
            girisForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formkayıt_Load(object sender, EventArgs e)
        {
            // Örneğin panelin adı: panelLogin
            panelKayıt.Left = (this.ClientSize.Width - panelKayıt.Width) / 2;
            panelKayıt.Top = (this.ClientSize.Height - panelKayıt.Height) / 2;
            panelKayıt.Anchor = AnchorStyles.None;  // Ortada sabit kalsın

        }
    }
}
