using BtkProje.App.Sayfalar;
using BtkProje.Servis;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

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

        Dictionary<SayfaTurleri, XtraTabPage> sayfalar =
            new Dictionary<SayfaTurleri, XtraTabPage>();
        enum SayfaTurleri { Kullanicilar = 0, Ayarlar = 1 };

        void SayfaKapat(XtraTabPage tabPage)
        {
            xtraTabControlMain.TabPages.Remove(tabPage);

            if (tabPage.Tag != null)//Cebinde anahtar var
            {
                SayfaTurleri sayfaTuru = (SayfaTurleri)tabPage.Tag;

                sayfalar.Remove(sayfaTuru);
            }
        }

        void SayfaAc(SayfaTurleri turu, string baslik, Image image, bool tekrarEdebilirMi = false)
        {

            if (!tekrarEdebilirMi)
            {
                if (sayfalar.ContainsKey(turu))//Sayfa daha önce açýlmýþ mý?
                {
                    XtraTabPage eskiSayfa = sayfalar[turu];
                    eskiSayfa.Show();//sayfayý göster ve çýk
                    return;
                }
            }

            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = baslik;
            tabPage.ImageOptions.Image = image;
            tabPage.Tag = turu;//*******

            //Sayfa içeriðini oluþtur ve ekle
            UserControl icerik = null;

            if (turu == SayfaTurleri.Kullanicilar)
                icerik = new UcKullanicilar();
            else if (turu == SayfaTurleri.Ayarlar)
                icerik = new UcAyarlar();

            tabPage.Controls.Add(icerik);
            icerik.Dock = DockStyle.Fill;
            /////////////////////////////////////////////////

            //Sonrasý için sakla, iki kere ayný sayfayý açma
            if (!tekrarEdebilirMi)
                sayfalar.Add(SayfaTurleri.Ayarlar, tabPage);

            xtraTabControlMain.TabPages.Add(tabPage);
            tabPage.Show();
        }
        private void nbiKullanicilar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(SayfaTurleri.Kullanicilar, "Kullanýcýlar", Properties.Resources.usergroup_32x32, true);
        }

        private void nbiAyarlar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(SayfaTurleri.Ayarlar, "Ayarlar", Properties.Resources.properties_32x32);
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs ea2 = (ClosePageButtonEventArgs)e;

            SayfaKapat((XtraTabPage)ea2.Page);
        }

        private void xtraTabPage1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbServisi.Kaydet();

            XtraMessageBox.Show("Veriler kayýt edildi.","Bilgi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
