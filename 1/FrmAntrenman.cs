using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1
{
    public partial class FrmAntrenman : Form
    {
        public FrmAntrenman()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");

        private void FrmAntrenman_Load(object sender, EventArgs e)
        {
          
            UyeGetir();

          
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

        void ProgramListele()
        {
            
            try
            {
                int secilenUyeID = Convert.ToInt32(comboBox1.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter("SELECT HareketAdi, SetSayisi, TekrarSayisi FROM Tbl_Antrenmanlar WHERE KullaniciID=" + secilenUyeID, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (comboBox1.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen hareket bilgilerini doldurun!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Antrenmanlar (KullaniciID, HareketAdi, SetSayisi, TekrarSayisi) VALUES (@p1, @p2, @p3, @p4)", baglanti);

                
                komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@p2", textBox1.Text); 
                komut.Parameters.AddWithValue("@p3", textBox2.Text);
                komut.Parameters.AddWithValue("@p4", textBox3.Text); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Hareket Başarıyla Eklendi!");
                ProgramListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramListele();
        }

        void TabloDuzenle()
        {
            
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        }
    }
}