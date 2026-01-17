using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

      
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            UyeGetir();

            GidenKutusu();

          
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

        void GidenKutusu()
        {
           
            string sorgu = "SELECT K.AdSoyad AS [Kime], M.Konu, M.Icerik, M.Tarih " +
                           "FROM Tbl_Mesajlar M " +
                           "INNER JOIN Tbl_Kullanicilar K ON M.AliciID = K.KullaniciID " +
                           "ORDER BY M.Tarih DESC";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.Text == "" || textBox1.Text == "" || richTextBox1.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Mesajlar (GonderenID, AliciID, Konu, Icerik) VALUES (@p1, @p2, @p3, @p4)", baglanti);

                komut.Parameters.AddWithValue("@p1", 1); 
                komut.Parameters.AddWithValue("@p2", comboBox1.SelectedValue); 
                komut.Parameters.AddWithValue("@p3", textBox1.Text); 
                komut.Parameters.AddWithValue("@p4", richTextBox1.Text); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Mesaj başarıyla gönderildi!");

                
                textBox1.Clear();
                richTextBox1.Clear();

                
                GidenKutusu();
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

            
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }
    }
}