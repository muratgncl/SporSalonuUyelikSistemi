using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace _1
{
    public partial class FrmAnaPanel : Form
    {
        public FrmAnaPanel()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;


            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 140, 0);
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;


            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);


            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 35;
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");


        void Listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT K.KullaniciID, K.AdSoyad, K.KullaniciAdi, K.Sifre, D.Telefon FROM Tbl_Kullanicilar K LEFT JOIN Tbl_UyeDetay D ON K.KullaniciID = D.KullaniciID WHERE K.Rol=2", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void IstatistikleriGetir()
        {
            baglanti.Open();

            
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Kullanicilar WHERE Rol=2", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUyeSayisi.Text = dr1[0].ToString() + " Kişi";
            }
            baglanti.Close();

           
            baglanti.Open();
           
            SqlCommand komut2 = new SqlCommand("SELECT SUM(O.Tutar) FROM Tbl_Odemeler O INNER JOIN Tbl_Kullanicilar K ON O.KullaniciID = K.KullaniciID", baglanti);
            object sonuc = komut2.ExecuteScalar(); 

            if (sonuc != DBNull.Value && sonuc != null)
            {
                lblToplamTutar.Text = sonuc.ToString() + " TL";
            }
            else
            {
                lblToplamTutar.Text = "0 TL";
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Duyurular", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblDuyuruSayisi.Text = dr3[0].ToString() + " Adet";
            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();


                SqlCommand komut1 = new SqlCommand("INSERT INTO Tbl_Kullanicilar (AdSoyad, KullaniciAdi, Sifre, Rol) VALUES (@p1, @p2, @p3, 2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", textBox1.Text);
                komut1.Parameters.AddWithValue("@p2", textBox2.Text);
                komut1.Parameters.AddWithValue("@p3", textBox3.Text);
                komut1.ExecuteNonQuery();


                SqlCommand komutID = new SqlCommand("SELECT IDENT_CURRENT('Tbl_Kullanicilar')", baglanti);
                int sonId = Convert.ToInt32(komutID.ExecuteScalar());


                SqlCommand komut2 = new SqlCommand("INSERT INTO Tbl_UyeDetay (KullaniciID, Telefon) VALUES (@p1, @p2)", baglanti);
                komut2.Parameters.AddWithValue("@p1", sonId);
                komut2.Parameters.AddWithValue("@p2", textBox4.Text);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("INSERT INTO Tbl_Olcumler (KullaniciID, Boy, Kilo, YagOrani) VALUES (@p1, 0, 0, 0)", baglanti);
                komut3.Parameters.AddWithValue("@p1", sonId);
                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Üye Başarıyla Eklendi!");
                Listele();
                IstatistikleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek satırı seçiniz!");
                    return;
                }


                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string secilenIsim = dataGridView1.CurrentRow.Cells[1].Value.ToString();


                DialogResult cevap = MessageBox.Show(secilenIsim + " adlı üyeyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komutSilOlcum = new SqlCommand("DELETE FROM Tbl_Olcumler WHERE KullaniciID=@p1", baglanti);
                    komutSilOlcum.Parameters.AddWithValue("@p1", secilenId);
                    komutSilOlcum.ExecuteNonQuery();


                    SqlCommand komutSilDetay = new SqlCommand("DELETE FROM Tbl_UyeDetay WHERE KullaniciID=@p1", baglanti);
                    komutSilDetay.Parameters.AddWithValue("@p1", secilenId);
                    komutSilDetay.ExecuteNonQuery();


                    SqlCommand komutSilAna = new SqlCommand("DELETE FROM Tbl_Kullanicilar WHERE KullaniciID=@p1", baglanti);
                    komutSilAna.Parameters.AddWithValue("@p1", secilenId);
                    komutSilAna.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Silindi!");


                    Listele();
                    IstatistikleriGetir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDuyurular fr = new FrmDuyurular();
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA VAR: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAntrenman fr = new FrmAntrenman();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaPanel_Load(object sender, EventArgs e)
        {
            Listele();
            IstatistikleriGetir();
        }

        private void lblDuyuruSayisi_Click(object sender, EventArgs e)
        {

        }
    }
}