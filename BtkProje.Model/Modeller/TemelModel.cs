using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TemelModel
    {
        public int? OlusturanKullanici { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? GuncelleyenKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
