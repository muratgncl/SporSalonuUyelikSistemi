using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1
{
    public partial class FrmUyeGiris : Form
    {
        public FrmUyeGiris()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SporSalonuDB;Integrated Security=True");

        private void UyeGirisBttn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();


                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2 AND Rol=2", baglanti);

                komut.Parameters.AddWithValue("@p1", UyeNoTxtBox.Text);
                komut.Parameters.AddWithValue("@p2", UyeSifreTxtBox.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı! Spor Salonuna Hoşgeldiniz.");
                    FrmUyeEkrani fr = new FrmUyeEkrani();
                    fr.gelenKullaniciAdi = UyeNoTxtBox.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void UyeNoLbl_Click(object sender, EventArgs e)
        {

        }

        private void UyeSifreLbl_Click(object sender, EventArgs e)
        {

        }
    }
}