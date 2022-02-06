using MediatR.API.Models;

namespace MediatR.API.Commands
{
    public class CreateOrderCommand: IRequest<Order>
    {
        public CreateOrderRequest Order { get; set; }
        public CreateOrderCommand(CreateOrderRequest _request)
        {
            Order = _request;
        }
    }
}
