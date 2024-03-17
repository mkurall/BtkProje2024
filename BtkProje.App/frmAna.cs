using BtkProje.App.Sayfalar;
using DevExpress.XtraTab;

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
                //Oturum a�t�ktan sonra ne istersiniz yaz�n

            }
        }

        Dictionary<SayfaTurleri, XtraTabPage> sayfalar =
            new Dictionary<SayfaTurleri, XtraTabPage>();
        enum SayfaTurleri { Kullanicilar = 0, Ayarlar=1 };

        void SayfaAc(SayfaTurleri turu, string baslik, Image image,bool tekrarEdebilirMi=false)
        {
            //Sayfa daha �nce a��lm�� m�?
            if (!tekrarEdebilirMi)
            {
                if (sayfalar.ContainsKey(turu))
                {
                    XtraTabPage eskiSayfa = sayfalar[turu];
                    eskiSayfa.Show();//sayfay� g�ster ve ��k
                    return;
                }
            }

            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = baslik;
            tabPage.ImageOptions.Image = image;

            //Sayfa i�eri�ini olu�tur ve ekle
            UserControl icerik = null;

            if (turu == SayfaTurleri.Kullanicilar)
                icerik = new UcKullanicilar();
            else if (turu == SayfaTurleri.Ayarlar)
                icerik = new UcAyarlar();

            tabPage.Controls.Add(icerik);
            icerik.Dock = DockStyle.Fill;
            /////////////////////////////////////////////////

            //Sonras� i�in sakla, iki kere ayn� sayfay� a�ma
            if(!tekrarEdebilirMi)
             sayfalar.Add(SayfaTurleri.Ayarlar, tabPage);

            xtraTabControlMain.TabPages.Add(tabPage);
            tabPage.Show();
        }
        private void nbiKullanicilar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(SayfaTurleri.Kullanicilar, "Kullan�c�lar", Properties.Resources.usergroup_32x32,true);
        }

        private void nbiAyarlar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(SayfaTurleri.Ayarlar, "Ayarlar", Properties.Resources.properties_32x32);
        }
    }
}
