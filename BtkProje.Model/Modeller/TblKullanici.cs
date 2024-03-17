using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TblKullanici : TemelModel
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string KullaniciAdi { get; set; }
        [MaxLength(50)]
        public string Parola { get; set; }
        [MaxLength(50)]
        public string? Ad { get; set; }
        [MaxLength(50)]
        public string? Soyad { get; set; }
        public YetkiTurleri Yetki { get; set; }
    }
}
