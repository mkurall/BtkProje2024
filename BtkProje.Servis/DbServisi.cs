using BtkProje.Model.Db;
using BtkProje.Model.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Servis
{
    public static class DbServisi
    {
        static BtkProjeDbContext ctx = new BtkProjeDbContext();
        public static TblKullanici OturumAcanKullanici { get; set; }

        public static List<TblKullanici> KullaniciListesi()
        {
            return ctx.Kullanicilar.ToList();
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
