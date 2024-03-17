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
        

        //public BtkProjeDbContext(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}
        
        //EF Core Tools Bunu kullanacak
        public BtkProjeDbContext()
        {
            connectionString = "Server=.\\SQLEXPRESS;Database=btk_proje_db;Trusted_Connection=True;Encrypt=False";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<TblKullanici> Kullanicilar { get; set; }
    }
}
