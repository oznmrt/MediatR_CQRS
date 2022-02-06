using MediatR.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatR.API.Repository
{
    public interface IOrderRepository
    {
        Task<Order> GetById(int id);
        Task<List<Order>> GetAll();
        Task<Order> Save(Order order);
    }
}
