using MediatR.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.API.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Order>> GetAll()
        {
            return await _appDbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _appDbContext.Orders.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Order> Save(Order order)
        {
            await  _appDbContext.AddAsync(order);
            await _appDbContext.SaveChangesAsync();
            return order;
        }
    }
}
