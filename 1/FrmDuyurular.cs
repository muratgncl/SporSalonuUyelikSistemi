using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
            Listele(); 
        }

       
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");



        void Listele()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT Metin AS 'Duyuru', Tarih FROM Tbl_Duyurular ORDER BY Tarih DESC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Lütfen bir duyuru metni yazın!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular (Metin) VALUES (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Duyuru Sisteme Kaydedildi!");
                richTextBox1.Clear(); 
                Listele(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Lütfen bir duyuru metni yazın!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular (Metin) VALUES (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Duyuru başarıyla eklendi!");
                richTextBox1.Clear(); 
                Listele();
                FrmAnaPanel anaPanel = (FrmAnaPanel)Application.OpenForms["FrmAnaPanel"];
                if (anaPanel != null)
                {
                    anaPanel.IstatistikleriGetir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }
    }
}