namespace OnlineStore.Models.Entities
{
    public class CartDetail
    {
        public int CartDetailId { get; set; }
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        public int ShoppingCartId { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Product Product { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
