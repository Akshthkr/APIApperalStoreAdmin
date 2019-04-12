using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApperalStoreAPI.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
              .HasOne(v=>v.Vendor)
              .WithMany(p => p.Products)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
             .HasOne(b=>b.Brand)
             .WithMany(p => p.Products)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
            .HasOne(c=>c.Customer)
            .WithMany(o => o.Orders)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                .HasColumnName("categoryName").HasMaxLength(10).IsUnicode(false);
            });

            modelBuilder.Entity<OrderProduct>(Build =>
            {
                Build.HasKey(t => new { t.OrderId, t.Productid });
            });
        }
    }
}
