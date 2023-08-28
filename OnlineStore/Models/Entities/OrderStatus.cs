namespace OnlineStore.Models.Entities
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }

        public string? OrderStatusName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
