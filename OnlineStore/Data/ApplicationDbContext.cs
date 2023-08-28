using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.ConfigureClasses;
using OnlineStore.Models.Entities;

namespace OnlineStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CartDetail> CartDetails => Set<CartDetail>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderList> OrderList => Set<OrderList>();
        public DbSet<OrderStatus> OrderStatus => Set<OrderStatus>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ShoppingCart> ShoppingCart => Set<ShoppingCart>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new CartDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderListConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingCartConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
        }
    }
}