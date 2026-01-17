using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1
{
    public partial class FrmAntrenorGiris : Form
    {
        public FrmAntrenorGiris()
        {
            InitializeComponent();
          
            this.Text = "Antrenör Giriş Paneli";
        }

       
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");

        private void AntGirisBttn_Click(object sender, EventArgs e)
        {
          
            bool girisBasarili = false;
            string kullaniciAdi = "";

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2 AND Rol=1", baglanti);
                komut.Parameters.AddWithValue("@p1", AntNoTxtBox.Text);
                komut.Parameters.AddWithValue("@p2", AntSifreTxtBox.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    
                    girisBasarili = true;
                    kullaniciAdi = dr["AdSoyad"].ToString(); 
                }

              
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                return; 
            }

            
            if (girisBasarili == true)
            {
                MessageBox.Show("Giriş Başarılı! Hoşgeldin " + kullaniciAdi);

                
                FrmAnaPanel fr = new FrmAnaPanel();
                fr.Show();

                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}