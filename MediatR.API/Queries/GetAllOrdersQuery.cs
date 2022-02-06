using MediatR.API.Models;
using System.Collections.Generic;

namespace MediatR.API.Queries
{
    public class GetAllOrdersQuery : IRequest<List<Order>>
    {
    }
}
