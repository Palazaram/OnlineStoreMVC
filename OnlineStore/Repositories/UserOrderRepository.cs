using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models.Entities;

namespace OnlineStore.Repositories
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManagerp;

        public UserOrderRepository(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor, 
            UserManager<IdentityUser> userManagerp)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
            _userManagerp = userManagerp;
        }

        public async Task<IEnumerable<Order>> UserOrders()
        {
            var userId = GetUserId();

            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User is not logged-in");
            }

            var orders = await _db.Orders.Include(x => x.OrderStatus)
                                .Include(x => x.OrderList)
                                .ThenInclude(x => x.Product)
                                .ThenInclude(p => p.Supplier)
                                .Include(p => p.OrderList)
                                .ThenInclude(p => p.Product)
                                .ThenInclude(p => p.Category)
                                .Where(x => x.UserId == userId)
                                .ToListAsync();
            return orders;
        }

        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManagerp.GetUserId(principal);
            return userId;
        }
    }
}
