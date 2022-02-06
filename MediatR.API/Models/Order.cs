using System.ComponentModel.DataAnnotations;

namespace MediatR.API.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }
    }
}
