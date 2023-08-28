namespace OnlineStore.Models.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
