using MediatR.API.Models;
using MediatR.API.Queries;
using MediatR.API.Repository;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Handlers
{
    public class GelAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<Order>>
    {
        private readonly IOrderRepository _orderRepository;

        public GelAllOrdersQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _orderRepository.GetAll();
        }
    }
}
