using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;
using OnlineStore.Models.Entities;
using OnlineStore.Models.DTOs;

namespace OnlineStore.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Supplier>> GetSupplierAsync()
        {
            return await _db.Suppliers.ToListAsync();
        }


        public async Task<IEnumerable<Product>> GetProductsAsync(string sTerm = "", int categoryId = 0, int supplierId = 0)
        {
            if (sTerm == null)
            {
                sTerm = "";
                sTerm = sTerm.ToLower();
            }
            else 
            {
                sTerm = sTerm.ToLower();
            }

            IEnumerable<Product> products = await (from product in _db.Products
                                                   join category in _db.Categories on product.CategoryId equals category.CategoryId
                                                   join supplier in _db.Suppliers on product.SupplierId equals supplier.SupplierId
                                                   where string.IsNullOrWhiteSpace(sTerm) || (product != null && product.ProductName.ToLower().StartsWith(sTerm))
                                                   select new Product
                                                   {
                                                       ProductId = product.ProductId,
                                                       ProductName = product.ProductName,
                                                       ProductDescription = product.ProductDescription,
                                                       ProductPrice = product.ProductPrice,
                                                       ProductImageName = product.ProductImageName,
                                                       CategoryId = product.CategoryId,
                                                       SupplierId = product.SupplierId,
                                                       Supplier = supplier,
                                                       Category = category
                                                   }).ToListAsync();

            if (categoryId > 0)
            {
                products = products.Where(p => p.CategoryId == categoryId);
            }

            if (supplierId > 0)
            {
                products = products.Where(p => p.SupplierId == supplierId);
            }

            return products;
        }

        public async Task<Product> GetProductByIdAsync(int? id) 
        {
            Product? product = await _db.Products.FirstOrDefaultAsync(p => p.ProductId == id);
            return product;
        }

        public async Task AddProductAsync(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Product product)
        {
            _db.Entry(product).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
        }

    }
}
