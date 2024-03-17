namespace BtkProje.App
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Shown(object sender, EventArgs e)
        {
            frmGiris form = new frmGiris();
            if (form.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                //Oturum açtýktan sonra ne istersiniz yazýn

            }
        }
    }
}
