using BtkProje.Model.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Db
{
    public class BtkProjeDbContext : DbContext
    {
        
        private string connectionString;
        

        //EF Core Tools Bunu(ilk yapıcıyı) kullanacak
        public BtkProjeDbContext()
        {
            this.connectionString = "Server=.\\SQLEXPRESS;Database=btk_proje_db;Trusted_Connection=True;Encrypt=False";
        }

        public BtkProjeDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<TblKullanici> Kullanicilar { get; set; }
    }
}
