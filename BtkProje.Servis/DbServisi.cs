using BtkProje.Model.Db;
using BtkProje.Model.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Servis
{
    public static class DbServisi
    {
        static BtkProjeDbContext ctx = new BtkProjeDbContext();
        public static TblKullanici OturumAcanKullanici { get; private set; }

        public static void Kaydet()
        {
            ctx.SaveChanges();
        }

        public static List<TblKullanici> KullaniciListesi()
        {
            return ctx.Kullanicilar.ToList();
        }
        public static BindingList<TblKullanici> KullaniciBagliListesi()
        {
            ctx.Kullanicilar.Load();
            return ctx.Kullanicilar.Local.ToBindingList();
        }

        public static bool OturumAc(string kullaniciAdi, string parola)
        {
            TblKullanici kull = ctx.Kullanicilar.
                FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi &&
                x.Parola == parola);

            if (kull != null)
            {
                OturumAcanKullanici = kull;
                return true;
            }
            else
                return false;
        }
    }
}
