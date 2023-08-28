using OnlineStore.Models.Entities;

namespace OnlineStore.Repositories
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();
    }
}