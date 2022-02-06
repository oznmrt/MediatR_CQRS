using MediatR.API.Commands;
using MediatR.API.Models;
using MediatR.API.Repository;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Handlers.CommandsHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.Save(new Order
            {
                Name = request.Order.OrderName,
                Number = request.Order.OrderNumber,
            });

            return order;
        }
    }
}
