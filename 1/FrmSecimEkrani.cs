namespace _1
{
    public partial class FrmSecimEkrani : Form
    {
        public FrmSecimEkrani()
        {
            InitializeComponent();
        }

        private void UyeGirisBttn_Click(object sender, EventArgs e)
        {
            FrmUyeGiris form3 = new FrmUyeGiris();
            form3.Show();
        }

        private void AntGirisBttn_Click(object sender, EventArgs e)
        {
            FrmAntrenorGiris form2 = new FrmAntrenorGiris();
            form2.Show();
        }
    }
}
