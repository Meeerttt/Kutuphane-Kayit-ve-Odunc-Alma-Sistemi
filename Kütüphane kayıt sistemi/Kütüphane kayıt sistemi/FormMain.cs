using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Kütüphane_kayıt_sistemi
{
    public partial class FormMain : Form
    {
        public static string girisYapanKullaniciAdi;
        public static int girisYapanKullaniciID;
        public FormMain()
        {
            InitializeComponent();
            girisYapanKullaniciID = Formgiris.girisYapanKullaniciID;
            BilgileriGetir(); // Profil bilgilerini yükle
            KategorileriYukle();
        }

        private void KategorileriYukle()
        {
            string connString = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sorgu = "SELECT kategoriadi FROM kategoriler";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, conn))
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbKategori.Items.Add(dr["kategoriadi"].ToString());
                    }
                }
            }
        }

        private void KitaplariListele()
        {
            string connString = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sorgu;
                bool hepsiSecildi = cmbKategori.SelectedItem != null && cmbKategori.SelectedItem.ToString() == "Hepsi";

                if (!hepsiSecildi && cmbKategori.SelectedItem != null)
                {
                    sorgu = @"SELECT k.kitapid, k.kitapadi, k.yazar, k.stok, kat.kategoriadi
                      FROM kitaplar k
                      JOIN kategoriler kat ON k.kategoriid = kat.kategoriid
                      WHERE kat.kategoriadi = @kategoriadi";
                }
                else
                {
                    sorgu = @"SELECT k.kitapid, k.kitapadi, k.yazar, k.stok, kat.kategoriadi
                      FROM kitaplar k
                      JOIN kategoriler kat ON k.kategoriid = kat.kategoriid";
                }

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, conn))
                {
                    if (!hepsiSecildi && cmbKategori.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@kategoriadi", cmbKategori.SelectedItem.ToString());
                    }

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgwkitaplar.DataSource = dt;
                }
            }
        }
        private void BilgileriGetir()
        {
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=mert2004;Database=Kutuphane_db"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM kullanıcılar WHERE kullaniciadi = @kullaniciadi";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciadi", girisYapanKullaniciAdi); // giriş yapan kullanıcı adı olmalı
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Ad_txt.Text = reader["ad"].ToString();
                                Sad_txt.Text = reader["soyad"].ToString();
                                kullaniciAdi_txt.Text = reader["kullaniciadi"].ToString();
                                Şifre_txt.Text = reader["sifre"].ToString();
                                Tel_txt.Text = reader["telefon"].ToString();
                                Adres_txt.Text = reader["adres"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgileri getirirken hata oluştu: " + ex.Message);
            }
        }




        private void FormMain_Load(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT kategoriadi FROM kategoriler";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbKategori.Items.Add(dr["kategoriadi"].ToString());
                        }
                    }
                }
                KategorileriYukle();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbFiltrele.SelectedItem == null)
            {
                MessageBox.Show("Lütfen arama filtresi seçin.");
                return;
            }

            string filtre = cmbFiltrele.SelectedItem.ToString();
            string aranan = txtAra.Text.Trim();

            if (filtre != "kitapadi" && filtre != "yazar")
            {
                MessageBox.Show("Geçersiz arama filtresi!");
                return;
            }

            string connString = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sorgu = $@"
        SELECT k.kitapid, k.kitapadi, k.yazar, k.yayınyili, k.stok, kat.kategoriadi
        FROM kitaplar k
        JOIN kategoriler kat ON k.kategoriid = kat.kategoriid
        WHERE k.{filtre} ILIKE @aranan";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, conn))
                {
                    cmd.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgwkitaplar.DataSource = dt;
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004"))
                {
                    baglanti.Open();
                    string sql = "UPDATE kullanıcılar SET ad = @ad, soyad = @soyad, kullaniciadi = @kullaniciadi, sifre = @sifre, telefon = @telefon, adres = @adres WHERE kullaniciadi = @eskiKullaniciAdi";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", Ad_txt.Text);
                        komut.Parameters.AddWithValue("@soyad", Sad_txt.Text);
                        komut.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi_txt.Text);
                        komut.Parameters.AddWithValue("@sifre", Şifre_txt.Text);
                        komut.Parameters.AddWithValue("@telefon", Tel_txt.Text);
                        komut.Parameters.AddWithValue("@adres", Adres_txt.Text);
                        komut.Parameters.AddWithValue("@eskiKullaniciAdi", FormMain.girisYapanKullaniciAdi);

                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMain.girisYapanKullaniciAdi = kullaniciAdi_txt.Text;
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            if (dgwkitaplar.CurrentRow != null)
            {
                int kitapID = Convert.ToInt32(dgwkitaplar.CurrentRow.Cells["kitapid"].Value);

                string baglantiMetni = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";
                using (NpgsqlConnection conn = new NpgsqlConnection(baglantiMetni))
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {

                            string stokKontrol = "SELECT stok FROM kitaplar WHERE kitapid = @kitapid";
                            using (var stokCmd = new NpgsqlCommand(stokKontrol, conn))
                            {
                                stokCmd.Parameters.AddWithValue("@kitapid", kitapID);
                                int mevcutStok = Convert.ToInt32(stokCmd.ExecuteScalar());

                                if (mevcutStok <= 0)
                                {
                                    MessageBox.Show("Bu kitap stokta kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }


                            string kontrolSorgu = @"SELECT COUNT(*) FROM oduncislemleri 
                                        WHERE kullaniciid = @kullaniciid 
                                        AND kitapid = @kitapid 
                                        AND durum = 'Teslim Edilmedi'";
                            using (var kontrolCmd = new NpgsqlCommand(kontrolSorgu, conn))
                            {
                                kontrolCmd.Parameters.AddWithValue("@kullaniciid", Formgiris.girisYapanKullaniciID);
                                kontrolCmd.Parameters.AddWithValue("@kitapid", kitapID);
                                int mevcutKayit = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                                if (mevcutKayit > 0)
                                {
                                    MessageBox.Show("Bu kitabı zaten ödünç aldınız. Önce teslim etmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }


                            string oduncEkle = @"INSERT INTO oduncislemleri (kullaniciid, kitapid, odunctarihi, iadetarihi, durum)
                                     VALUES (@kullaniciid, @kitapid, @odunctarihi, @iadetarihi, @durum)";
                            using (var cmd = new NpgsqlCommand(oduncEkle, conn))
                            {
                                cmd.Parameters.AddWithValue("@kullaniciid", Formgiris.girisYapanKullaniciID);
                                cmd.Parameters.AddWithValue("@kitapid", kitapID);
                                cmd.Parameters.AddWithValue("@odunctarihi", DateTime.Now);
                                cmd.Parameters.AddWithValue("@iadetarihi", DateTime.Now.AddDays(15));
                                cmd.Parameters.AddWithValue("@durum", "Teslim Edilmedi");
                                cmd.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Ödünç alma işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        private void OduncKitaplarimiListele()
        {
            string connStr = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();


                string sorgu = @"
            SELECT o.oduncid, k.kitapadi, o.odunctarihi, o.iadetarihi, 
                   'Teslim Edilmedi' AS durum
            FROM oduncislemleri o
            INNER JOIN kitaplar k ON o.kitapid = k.kitapid
            WHERE o.kullaniciid = @kullaniciid 
            AND o.durum != 'Teslim Edildi'
            ORDER BY o.odunctarihi DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciid", Formgiris.girisYapanKullaniciID);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgwOduncListele.DataSource = dt;


                    dgwOduncListele.Columns["oduncid"].HeaderText = "İşlem No";
                    dgwOduncListele.Columns["kitapadi"].HeaderText = "Kitap Adı";
                    dgwOduncListele.Columns["odunctarihi"].HeaderText = "Ödünç Tarihi";
                    dgwOduncListele.Columns["iadetarihi"].HeaderText = "İade Tarihi";
                    dgwOduncListele.Columns["durum"].HeaderText = "Durum";
                }
            }
        }
        private void OduncListele_Click(object sender, EventArgs e)
        {
            OduncKitaplarimiListele();
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (dgwOduncListele.SelectedRows.Count > 0)
            {
                int oduncId = Convert.ToInt32(dgwOduncListele.SelectedRows[0].Cells["oduncid"].Value);
                int kitapId = GetKitapIdFromOduncId(oduncId);

                string connStr = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();


                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string durumKontrol = "SELECT durum FROM oduncislemleri WHERE oduncid = @oduncid";
                            using (NpgsqlCommand durumCmd = new NpgsqlCommand(durumKontrol, conn, transaction))
                            {
                                durumCmd.Parameters.AddWithValue("@oduncid", oduncId);
                                string durum = durumCmd.ExecuteScalar()?.ToString();

                                if (durum == "Teslim Edildi")
                                {
                                    MessageBox.Show("Bu kitap zaten teslim edilmiş!");
                                    return;
                                }
                            }


                            string updateSorgu = @"UPDATE oduncislemleri 
                                         SET durum = 'Teslim Edildi', iadetarihi = @iadetarihi 
                                         WHERE oduncid = @oduncid";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(updateSorgu, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@iadetarihi", DateTime.Today);
                                cmd.Parameters.AddWithValue("@oduncid", oduncId);
                                cmd.ExecuteNonQuery();
                            }


                            string stokGuncelle = "UPDATE kitaplar SET stok = stok + 1 WHERE kitapid = @kitapid";
                            using (NpgsqlCommand stokCmd = new NpgsqlCommand(stokGuncelle, conn, transaction))
                            {
                                stokCmd.Parameters.AddWithValue("@kitapid", kitapId);
                                stokCmd.ExecuteNonQuery();
                            }


                            transaction.Commit();

                            MessageBox.Show("Kitap başarıyla teslim edildi.");
                            OduncKitaplarimiListele();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Teslim işlemi sırasında hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen teslim edilecek bir kitap seçin.");
            }
        }

        private int GetKitapIdFromOduncId(int oduncId)
        {
            string connStr = "Host=localhost;Port=5432;Database=Kutuphane_db;Username=postgres;Password=mert2004";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string sorgu = "SELECT kitapid FROM oduncislemleri WHERE oduncid = @oduncid";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, conn))
                {
                    cmd.Parameters.AddWithValue("@oduncid", oduncId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int kitapId))
                    {
                        return kitapId;
                    }
                    else
                    {
                        throw new Exception("İlgili kitap ID'si bulunamadı.");
                    }
                }
            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Formgiris girisForm = new Formgiris();
            girisForm.Show();
            this.Hide();
        }
        



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Formgiris girisForm = new Formgiris();
            girisForm.Show();
            this.Hide();
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void dgwkitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
            panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
            panelMain.Anchor = AnchorStyles.None;  

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Formgiris girisForm = new Formgiris();
            girisForm.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    } 
}
