using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Models.Entities;

namespace OnlineStore.ConfigureClasses
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasKey(os => os.OrderStatusId);

            builder.Property(os => os.OrderStatusName).IsRequired().HasColumnType("NVARCHAR(20)");

            builder.HasData(
                new OrderStatus 
                {
                    OrderStatusId = 1,
                    OrderStatusName = "Pending"
                },
                new OrderStatus
                {
                    OrderStatusId = 2,
                    OrderStatusName = "Completed"
                },
                new OrderStatus
                {
                    OrderStatusId = 3,
                    OrderStatusName = "Shipped"
                },
                new OrderStatus
                {
                    OrderStatusId = 4,
                    OrderStatusName = "Cancelled"
                },
                new OrderStatus
                {
                    OrderStatusId = 5,
                    OrderStatusName = "Declined"
                },
                new OrderStatus
                {
                    OrderStatusId = 6,
                    OrderStatusName = "Refunded"
                },
                new OrderStatus
                {
                    OrderStatusId = 7,
                    OrderStatusName = "Disputed"
                });
        }
    }
}
