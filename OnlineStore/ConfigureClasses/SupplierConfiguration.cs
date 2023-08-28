using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(s => s.SupplierId);

            builder.Property(s => s.SupplierName).IsRequired().HasColumnType("NVARCHAR(30)");
            builder.Property(s => s.SupplierPhone).IsRequired().HasColumnType("NVARCHAR(30)");
            builder.Property(s => s.SupplierEmail).IsRequired().HasColumnType("NVARCHAR(30)");

            builder.HasData(
                    new Supplier 
                    {
                        SupplierId = 1,
                        SupplierName = "Велес",
                        SupplierPhone = "+380 (67) 716-14-19",
                        SupplierEmail = "veles@gmail.com"
                    },
                    new Supplier 
                    {
                        SupplierId = 2,
                        SupplierName = "Геліос",
                        SupplierPhone = "+380 (66) 312-77-80",
                        SupplierEmail = "helios@gmail.com"
                    },
                    new Supplier
                    {
                        SupplierId = 3,
                        SupplierName = "Флорамаркет",
                        SupplierPhone = "+380 (67) 273-61-10",
                        SupplierEmail = "floramarket@gmail.com"
                    }
                );
        }
    }
}
