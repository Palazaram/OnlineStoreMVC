using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductName).IsRequired().HasColumnType("NVARCHAR(100)");
            builder.Property(p => p.ProductDescription).HasColumnType("NVARCHAR(450)");
            builder.Property(p => p.ProductPrice).IsRequired().HasColumnType("MONEY");
            builder.Property(p => p.ProductImageName).HasColumnType("NVARCHAR(450)");

            builder.Ignore(p => p.ProductImage);

            builder.HasCheckConstraint("CK_ProductPrice", "ProductPrice >= 0");

            builder.HasOne(p => p.Category).WithMany(с => с.Products).HasForeignKey(p => p.CategoryId); 
            builder.HasOne(p => p.Supplier).WithMany(s => s.Products).HasForeignKey(p => p.SupplierId);


            builder.HasData(
                new Product 
                {
                    ProductId = 1,
                    ProductName = "ОГІРОК АКТОР F1",
                    ProductDescription = "Середньоранній (50-54 дні) гібрид корніншонного типу.",
                    ProductPrice = 9.00m,
                    ProductImageName = "vegetables/cucumber/sm_ogurec-akter.jpg",
                    CategoryId = 1,
                    SupplierId = 1,
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "КАПУСТА АГРЕСОР F1",
                    ProductDescription = "Пізній сорт селекції голландської фірми Syngenta. Термін дозрівання 115-120 днів.",
                    ProductPrice = 18.00m,
                    ProductImageName = "vegetables/cabbage/sm_agressor.jpg",
                    CategoryId = 1,
                    SupplierId = 2,
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "БАКЛАЖАН АЛМАЗ",
                    ProductDescription = "Середньостиглий, технічна стиглість плодів настає через 118-120 днів після сходів.",
                    ProductPrice = 6.20m,
                    ProductImageName = "vegetables/eggplant/sm_almaz.jpg",
                    CategoryId = 1,
                    SupplierId = 3,
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "БУРЯК ЄГИПЕТСЬКИЙ ПЛОСКИЙ",
                    ProductDescription = "Середньоранній високоврожайний сорт. Період вегетації становить 80-110 днів.",
                    ProductPrice = 6.00m,
                    ProductImageName = "vegetables/sugarbeet/sm_egipetskaya-ploskaya.jpg",
                    CategoryId = 1,
                    SupplierId = 1,
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "ДИНЯ ІНЕЯ",
                    ProductDescription = "Новий середньостиглий сорт селекції Дніпропетровської дослідної станції.",
                    ProductPrice = 6.20m,
                    ProductImageName = "fruits/melon/sm_ineya.jpg",
                    CategoryId = 2,
                    SupplierId = 1,
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "КАВУН ІМПЕРАТОР F1",
                    ProductDescription = "Середньоранній (80-90 днів) італійський гібрид кавуна для відкритого ґрунту і плівкових укриттів.",
                    ProductPrice = 14.00m,
                    ProductImageName = "fruits/watermelon/sm_arbuz-imperator.jpg",
                    CategoryId = 2,
                    SupplierId = 3,
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "АЙСТРА АМЕРИКАНСЬКА КРАСУНЯ",
                    ProductDescription = "Сортотип американських кущових айстр.",
                    ProductPrice = 6.00m,
                    ProductImageName = "flowers/sm_amerikanskaya-krasavica.jpg",
                    CategoryId = 3,
                    SupplierId = 3,
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "АЙСТРА ІМПЕРІЯ",
                    ProductDescription = "Кущ компактний, висотою 50-55 см.",
                    ProductPrice = 6.00m,
                    ProductImageName = "flowers/sm_imperiya.jpg",
                    CategoryId = 3,
                    SupplierId = 2,
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "АЙСТРА ІВЕНУС",
                    ProductDescription = "Сортотип півонієвидних айстр. Кущ напіврозлогий, висотою 55-60 см.",
                    ProductPrice = 6.00m,
                    ProductImageName = "flowers/sm_ivenus.jpg",
                    CategoryId = 3,
                    SupplierId = 1,
                });
        }
    }
}
