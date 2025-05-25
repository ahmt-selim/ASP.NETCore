using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=BookStore;uid=sa;pwd=123");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDetail>().Ignore("ID");//OrderDetail tablosunda BaseEntity'den gelen ID kolonuna ihtiyaç duymadığımız için ignore ettik.
            modelBuilder.Entity<OrderDetail>().HasKey("OrderID", "ProductID");//HasKey ile primary keu olmasını sağladık.
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Oders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
