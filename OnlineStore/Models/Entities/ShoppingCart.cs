namespace OnlineStore.Models.Entities
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }

        public string UserId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
