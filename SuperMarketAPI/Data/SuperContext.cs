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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>().HasKey(s => s.UserId);
            modelBuilder.Entity<Category>().HasKey(c => c.CatId);
            modelBuilder.Entity<Product>().HasKey(p => p.ProdId);

            //Relação one-to-one entre User e Seller
            modelBuilder.Entity<User>().HasOptional(u => u.Seller).WithRequired(s => s.User);
            //Relação one-to-many (1 produto tem uma categoria mas 1 categoria pode ter varios produtos)
            modelBuilder.Entity<Product>().HasRequired<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey<int>(p => p.CatId);
        }
    }
}
