namespace BtkProje.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            frmGiris form = new frmGiris();
            form.ShowDialog();
        }
    }
}
