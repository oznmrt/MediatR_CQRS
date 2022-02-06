namespace MediatR.API.Models
{
    public class CreateOrderRequest
    {
        public string OrderNumber { get; set; }
        public string OrderName { get; set; }
    }
}
