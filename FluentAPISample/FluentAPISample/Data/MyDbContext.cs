using Microsoft.EntityFrameworkCore;

namespace FluentAPISample.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DetailedOrder> DetailedOrders { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(e =>
            {
                e.ToTable("OrderTable");
                e.HasKey(madh => madh.OrderId);
                e.Property(dh => dh.OrderDate).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.CustomerName).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<DetailedOrder>(entity =>
            {
                entity.ToTable("DetailerOrderList");
                entity.HasKey(e => new { e.ProductId, e.OrderId });

                entity.HasOne(e => e.Order)
                    .WithMany(e => e.DetailedOrders)
                    .HasForeignKey(e => e.OrderId)
                    .HasConstraintName("FK_DetailedOrder_Order");

                entity.HasOne(e => e.Product)
                 .WithMany(e => e.DetailedOrders)
                 .HasForeignKey(e => e.OrderId)
                 .HasConstraintName("FK_DetailedOrder_Product");
            }

            );
        }

    }
}
