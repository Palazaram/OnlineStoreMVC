using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class OrderListConfiguration : IEntityTypeConfiguration<OrderList>
    {
        public void Configure(EntityTypeBuilder<OrderList> builder)
        {
            builder.HasKey(ol => new { ol.OrderId, ol.ProductId });

            builder.Property(ol => ol.Quantity).HasColumnType("INT");
            builder.Property(ol => ol.UnitPrice).HasColumnType("MONEY");
            
            builder.HasCheckConstraint("CK_Quantity", "Quantity >= 0");

            builder.HasOne(ol => ol.Order).WithMany(o => o.OrderList).HasForeignKey(ol => ol.OrderId);
            builder.HasOne(ol => ol.Product).WithMany(p => p.OrderList).HasForeignKey(ol => ol.ProductId);
        }
    }
}
