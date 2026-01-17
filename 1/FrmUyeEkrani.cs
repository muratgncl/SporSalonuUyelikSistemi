using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1
{
    public partial class FrmUyeEkrani : Form
    {
        // Köprüden gelen kullanıcı adı burada tutuluyor
        public string gelenKullaniciAdi;

        // Veritabanından çekeceğimiz gizli ID
        int kullaniciID;

        public FrmUyeEkrani()
        {
            InitializeComponent();
        }

        // ⚠️ BURAYA KENDİ BAĞLANTI ADRESİNİ YAPIŞTIR:
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");

        private void FrmUyeEkrani_Load(object sender, EventArgs e)
        {
            // Form açılınca çalışacak metodlar
            BilgileriGetir();
            ProgramGetir();
            MesajlariGetir();

            // Tablo Makyajı
            TabloDuzenle(dataGridView1);
            TabloDuzenle(dataGridView2);
        }

        void BilgileriGetir()
        {
            baglanti.Open();

            // 1. Kullanıcı Adı ile ID ve Ad Soyad bul
            SqlCommand komut = new SqlCommand("SELECT KullaniciID, AdSoyad FROM Tbl_Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", gelenKullaniciAdi);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                kullaniciID = Convert.ToInt32(dr["KullaniciID"]);
                lblAdSoyad.Text = dr["AdSoyad"].ToString().ToUpper();
            }
            dr.Close();

            // 2. ID ile Boy, Kilo, Yağ verilerini çek (En son ölçüm)
            SqlCommand komut2 = new SqlCommand("SELECT TOP 1 Boy, Kilo, YagOrani FROM Tbl_Olcumler WHERE KullaniciID=@p1 ORDER BY OlcumTarihi DESC", baglanti);
            komut2.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr2 = komut2.ExecuteReader();

            if (dr2.Read())
            {
                // Verileri etiketlere yaz
                float boy = Convert.ToSingle(dr2["Boy"]);
                float kilo = Convert.ToSingle(dr2["Kilo"]);

                lblBoy.Text = "Boy: " + boy.ToString() + " cm";
                lblKilo.Text = "Kilo: " + kilo.ToString() + " kg";
                lblYag.Text = "Yağ Oranı: %" + dr2["YagOrani"].ToString();

                // 3. BMI Hesaplama (Otomatik)
                float boyMetre = boy / 100;
                float bmi = kilo / (boyMetre * boyMetre);
                lblBMI.Text = "VKE: " + bmi.ToString("0.00");

                // BMI'ye göre renk değiştirme (Görsel şov)
                if (bmi < 25) lblBMI.ForeColor = System.Drawing.Color.LightGreen;
                else lblBMI.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblBoy.Text = "Ölçüm verisi yok.";
            }

            baglanti.Close();
        }

        void ProgramGetir()
        {
            // Antrenman programını çek
            SqlDataAdapter da = new SqlDataAdapter("SELECT HareketAdi, SetSayisi, TekrarSayisi FROM Tbl_Antrenmanlar WHERE KullaniciID=" + kullaniciID, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void MesajlariGetir()
        {
            // Gelen mesajları çek
            SqlDataAdapter da = new SqlDataAdapter("SELECT Konu, Icerik, Tarih FROM Tbl_Mesajlar WHERE AliciID=" + kullaniciID + " ORDER BY Tarih DESC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void TabloDuzenle(DataGridView dgv)
        {
            // Senin sevdiğin beyaz/sade tema
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniBoy.Text == "" || txtYeniKilo.Text == "" || txtYeniYag.Text == "")
            {
                MessageBox.Show("Lütfen tüm değerleri giriniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti.Open();

            // 2. Yeni ölçüm kaydını veritabanına ekle
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Olcumler (KullaniciID, Boy, Kilo, YagOrani) VALUES (@p1, @p2, @p3, @p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", kullaniciID); // Giriş yapan kişinin ID'si zaten hafızadaydı
            komut.Parameters.AddWithValue("@p2", txtYeniBoy.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtYeniKilo.Text)); // Kilo virgüllü olabilir
            komut.Parameters.AddWithValue("@p4", txtYeniYag.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bilgileriniz güncellendi! Tebrikler.");

            // 3. Ekrandaki sarı yazıları anında yenile (Tekrar hesaplasın)
            BilgileriGetir();

            // 4. Kutuları temizle
            txtYeniBoy.Text = "";
            txtYeniKilo.Text = "";
            txtYeniYag.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
