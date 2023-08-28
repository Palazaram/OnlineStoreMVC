using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models.Entities;
using System.Security.Claims;

namespace OnlineStore.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManagerp;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRepository(ApplicationDbContext db, UserManager<IdentityUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManagerp = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> AddItem(int productId, int qty)
        {
            string userId = GetUserId();
            using var transaction = _db.Database.BeginTransaction();
            try
            {
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("User is not logged-in");
                }

                var cart = await GetCart(userId);

                if (cart is null)
                {
                    cart = new ShoppingCart
                    {
                        UserId = userId
                    };

                    _db.ShoppingCart.Add(cart);
                }
                _db.SaveChanges();
                //cart details section 

                var cartItem = _db.CartDetails
                    .FirstOrDefault(c => c.ShoppingCartId == cart.ShoppingCartId && c.ProductId == productId);

                if (cartItem is not null)
                {
                    cartItem.Quantity += qty;
                }
                else
                {
                    var product = _db.Products.Find(productId);
                    cartItem = new CartDetail
                    {
                        ProductId = productId,
                        ShoppingCartId = cart.ShoppingCartId,
                        Quantity = qty,
                        UnitPrice = product.ProductPrice
                    };
                    _db.CartDetails.Add(cartItem);
                }
                _db.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                
            }

            var cartItemCount = await GetCartItemCount(userId);
            return cartItemCount;
        }

        public async Task<int> RemoveItem(int productId)
        {
            string userId = GetUserId();
            try
            {
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("User is not logged-in");
                }

                var cart = await GetCart(userId);

                if (cart is null)
                {
                    throw new Exception("Invalid cart");
                }
                //cart details section 

                var cartItem = _db.CartDetails
                    .FirstOrDefault(c => c.ShoppingCartId == cart.ShoppingCartId && c.ProductId == productId);
                if (cartItem is null)
                {
                    throw new Exception("No items in cart");
                }
                else if (cartItem.Quantity == 1)
                {
                    _db.CartDetails.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity--;
                }
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }

            var cartItemCount = await GetCartItemCount(userId);
            return cartItemCount;
        }

        public async Task<ShoppingCart> GetUserCart()
        {
            var userId = GetUserId();

            if (userId == null)
            {
                throw new Exception("Invalid user ID");
            }

            var shoppingCart = await _db.ShoppingCart
                                        .Include(c => c.CartDetails)
                                        .ThenInclude(p => p.Product)
                                        .ThenInclude(p => p.Supplier)
                                        .Include(p => p.CartDetails)
                                        .ThenInclude(p => p.Product)
                                        .ThenInclude(p => p.Category)
                                        .Where(u => u.UserId == userId).FirstOrDefaultAsync();

            return shoppingCart;
        }

        public async Task<int> GetCartItemCount(string userId="") 
        {
            if (!string.IsNullOrEmpty(userId))
            {
                userId = GetUserId();
            }

            var date = await (from cart in _db.ShoppingCart
                        join cartDetails in _db.CartDetails
                        on cart.ShoppingCartId equals cartDetails.ShoppingCartId
                        select new { cartDetails.CartDetailId }).ToListAsync();

            return date.Count;
        }

        public async Task<ShoppingCart> GetCart(string userId)
        {
            var cart = await _db.ShoppingCart.FirstOrDefaultAsync(x => x.UserId == userId);
            return cart;
        }

        public async Task<bool> DoCheckout()
        {
            using var transaction = _db.Database.BeginTransaction();
            try
            {
                // logic
                // move data from cartDetail to order and order detail then we will remove cart detail
                var userId = GetUserId();
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("User is not logged-in");
                }

                var cart = await GetCart(userId);
                if (cart is null)
                {
                    throw new Exception("Invalid cart");
                }
                    
                var cartDetail = _db.CartDetails
                                    .Where(a => a.ShoppingCartId == cart.ShoppingCartId).ToList();

                if (cartDetail.Count == 0)
                {
                    throw new Exception("Cart is empty");
                }
                    
                var order = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    IsDeleted = false,
                    OrderStatusId = 1//pending
                };
                _db.Orders.Add(order);
                _db.SaveChanges();

                foreach (var item in cartDetail)
                {
                    var orderList = new OrderList
                    {
                        ProductId = item.ProductId,
                        OrderId = order.OrderId,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice
                    };
                    _db.OrderList.Add(orderList);
                }
                _db.SaveChanges();

                // removing the cartdetails
                _db.CartDetails.RemoveRange(cartDetail);
                _db.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string GetUserId() 
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManagerp.GetUserId(principal);
            return userId;
        }
    }
}
