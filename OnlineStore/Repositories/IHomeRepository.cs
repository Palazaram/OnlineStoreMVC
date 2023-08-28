using OnlineStore.Models.Entities;

namespace OnlineStore.Repositories
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Category>> GetCategoryAsync();
        Task<IEnumerable<Supplier>> GetSupplierAsync();
        Task<IEnumerable<Product>> GetProductsAsync(string sTerm = "", int categoryId = 0, int supplierId = 0);

        Task<Product> GetProductByIdAsync(int? id);

        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(Product product);
    }
}
