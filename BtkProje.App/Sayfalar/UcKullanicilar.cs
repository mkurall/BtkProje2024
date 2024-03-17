using BtkProje.Model.Modeller;
using BtkProje.Servis;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkProje.App.Sayfalar
{
    public partial class UcKullanicilar : UserControl
    {
        public UcKullanicilar()
        {
            InitializeComponent();

            repositoryItemButtonEdit1.ButtonClick += RepositoryItemButtonEdit1_ButtonClick;

            VerileriGetir();
        }

        private void RepositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            TblKullanici kullanici = gridView1.GetFocusedRow() as TblKullanici;

            if(kullanici != null)
            {
                DialogResult cevap = XtraMessageBox.Show(kullanici.KullaniciAdi + " adlı kullanıcı silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(cevap==DialogResult.Yes)
                {
                    DbServisi.KullaniciSil(kullanici);
                }

            }
        }

        void VerileriGetir()
        {
            var liste = DbServisi.KullaniciBagliListesi();
            gridControl1.DataSource = liste;
        }
    }
}
