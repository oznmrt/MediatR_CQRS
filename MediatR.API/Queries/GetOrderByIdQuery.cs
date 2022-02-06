using MediatR.API.Models;

namespace MediatR.API.Queries
{
    public class GetOrderByIdQuery: IRequest<Order>
    {
        public int OrderId { get; set; }
        public GetOrderByIdQuery(int _orderId)
        {
            OrderId = _orderId;
        }
    }
}
