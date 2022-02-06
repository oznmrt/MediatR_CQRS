using MediatR.API.Models;
using MediatR.API.Queries;
using MediatR.API.Repository;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Handlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderRepository.GetById(request.OrderId);
            return result;
        }
    }
}
