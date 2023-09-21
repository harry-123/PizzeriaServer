using PizzeriaServer.Models;

namespace PizzeriaServer.DAL.IRepositories
{
    public interface IOrdersRepository
    {
        int PlaceOrder(Order order);
    }
}
