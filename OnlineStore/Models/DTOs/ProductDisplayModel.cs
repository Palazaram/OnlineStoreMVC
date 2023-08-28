using Humanizer.Localisation;
using OnlineStore.Models.Entities;

namespace OnlineStore.Models.DTOs
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Supplier> Suppliers { get; set; }
        public string STerm { get; set; } = "";
        public int CategoryId { get; set; } = 0;
        public int SupplierId { get; set; } = 0;

        public PageViewModel PageViewModel { get; set; }
    }
}
