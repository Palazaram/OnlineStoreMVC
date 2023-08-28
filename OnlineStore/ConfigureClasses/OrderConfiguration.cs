using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.OrderId);

            builder.Property(o => o.OrderDate).IsRequired().HasColumnType("DATE");
            builder.Property(o => o.IsDeleted).IsRequired().HasColumnType("BIT");
            builder.Property(o => o.UserId).IsRequired().HasColumnType("NVARCHAR(450)");


            builder.HasOne(o => o.OrderStatus).WithMany(os => os.Orders).HasForeignKey(o => o.OrderStatusId);
        }
    }
}
