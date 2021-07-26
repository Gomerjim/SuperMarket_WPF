using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMarketAPI.Data
{
    public class SuperContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Seller> Sellers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>().HasKey(s => s.UserId);

            //Relação one-to-one entre User e Seller
            modelBuilder.Entity<User>().HasOptional(u => u.Seller).WithRequired(s => s.User);
        }
    }
}
