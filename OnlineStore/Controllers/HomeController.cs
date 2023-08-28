using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;
using OnlineStore.Models;
using OnlineStore.Models.DTOs;
using OnlineStore.Models.Entities;
using OnlineStore.Repositories;
using System.Diagnostics;
using System.IO;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IHomeRepository _homeRepository;

        //ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment,
            IHomeRepository homeRepository)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            _homeRepository = homeRepository;
            //_db = db;
        }

        public async Task<IActionResult> Index(int page = 1, string sterm = "", int categoryId = 0, int supplierId = 0)
        {
            int pageSize = 4;

            IEnumerable<Product> products = await _homeRepository.GetProductsAsync(sterm, categoryId, supplierId);
            IEnumerable<Category> categories = await _homeRepository.GetCategoryAsync();
            IEnumerable<Supplier> suppliers = await _homeRepository.GetSupplierAsync();

            var count =  products.Count();
            var items =  products.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            ProductDisplayModel productModel = new ProductDisplayModel
            {
                Products = items,
                Categories = categories,
                Suppliers = suppliers,
                STerm = sterm,
                CategoryId = categoryId,
                SupplierId = supplierId,
                PageViewModel = pageViewModel
            };
            return View(productModel);
        }

        public async Task<IActionResult> Create()
        {
            IEnumerable<Category> categories = await _homeRepository.GetCategoryAsync();
            IEnumerable<Supplier> suppliers = await _homeRepository.GetSupplierAsync();

            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
            ViewBag.Suppliers = new SelectList(suppliers, "SupplierId", "SupplierName");
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductImage != null)
                {
                    CreateImage(product);
                }
                await _homeRepository.AddProductAsync(product);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Product product = new Product { ProductId = id.Value };

                await _homeRepository.DeleteProductAsync(product);

                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            IEnumerable<Category> categories = await _homeRepository.GetCategoryAsync();
            IEnumerable<Supplier> suppliers = await _homeRepository.GetSupplierAsync();

            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
            ViewBag.Suppliers = new SelectList(suppliers, "SupplierId", "SupplierName");

            if (id != null)
            {
                Product? product = await _homeRepository.GetProductByIdAsync(id);
                if (product != null)
                {
                    return View(product);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product updatedProduct)
        {
            if (id != updatedProduct.ProductId)
            {
                return NotFound();
            }

            if (updatedProduct.ProductImage != null)
            {
                CreateImage(updatedProduct);
            }

            await _homeRepository.UpdateProductAsync(updatedProduct);
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async void CreateImage(Product product)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(product.ProductImage.FileName);
            string extension = Path.GetExtension(product.ProductImage.FileName);
            product.ProductImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/img/", fileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await product.ProductImage.CopyToAsync(fileStream);
            }
        }
    }
}