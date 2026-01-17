using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            
            UyeGetir();

           
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            comboBox2.Items.AddRange(aylar);

            
            Listele();

         
            TabloDuzenle();
        }

        void UyeGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT KullaniciID, AdSoyad FROM Tbl_Kullanicilar WHERE Rol=2", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "AdSoyad";
            comboBox1.ValueMember = "KullaniciID";
            comboBox1.DataSource = dt;
        }

        void Listele()
        {
            
            string sorgu = "SELECT K.AdSoyad, O.Ay, O.Tutar, O.OdenmeTarihi " +
                           "FROM Tbl_Odemeler O " +
                           "INNER JOIN Tbl_Kullanicilar K ON O.KullaniciID = K.KullaniciID " +
                           "ORDER BY O.OdenmeTarihi DESC";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen tüm bilgileri girin!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Odemeler (KullaniciID, Ay, Tutar) VALUES (@p1, @p2, @p3)", baglanti);

                komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@p2", comboBox2.Text);          
                komut.Parameters.AddWithValue("@p3", decimal.Parse(textBox1.Text)); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ödeme Başarıyla Alındı! Kasa Bereketli Olsun. 💵");
               
                FrmAnaPanel anaPanel = (FrmAnaPanel)Application.OpenForms["FrmAnaPanel"];
                anaPanel.IstatistikleriGetir();

                Listele(); 
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        void TabloDuzenle()
        {
           
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }
    }
}