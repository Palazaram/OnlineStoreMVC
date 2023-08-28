namespace OnlineStore.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsDeleted { get; set; } = false;


        public int OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        
        public virtual ICollection<OrderList> OrderList { get; set; }
    }
}
