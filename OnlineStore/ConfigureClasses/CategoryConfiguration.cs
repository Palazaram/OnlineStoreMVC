using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName).HasMaxLength(30).IsRequired().HasColumnType("NVARCHAR(30)");

            builder.HasData(
                    new Category
                    {
                        CategoryId = 1,
                        CategoryName = "Овочі"      
                    },
                    new Category
                    {
                        CategoryId = 2,
                        CategoryName = "Фрукти"     
                    },
                    new Category
                    {
                        CategoryId = 3,
                        CategoryName = "Квіти"      
                    }
                );
        }
    }
}
