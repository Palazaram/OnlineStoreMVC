using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(sc => sc.ShoppingCartId);

            builder.Property(sc => sc.UserId).IsRequired().HasColumnType("NVARCHAR(450)");
            builder.Property(sc => sc.IsDeleted).IsRequired().HasColumnType("BIT");
        }
    }
}
