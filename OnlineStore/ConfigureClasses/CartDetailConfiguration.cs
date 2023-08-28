using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(cd => cd.CartDetailId);
            
            builder.Property(cd => cd.Quantity).IsRequired().HasColumnType("INT");
            builder.Property(cd => cd.UnitPrice).IsRequired().HasColumnType("MONEY");

            builder.HasOne(cd => cd.Product).WithMany(p => p.CartDetails).HasForeignKey(cd => cd.ProductId);
            builder.HasOne(cd => cd.ShoppingCart).WithMany(sc => sc.CartDetails).HasForeignKey(cd => cd.ShoppingCartId);
        }
    }
}
