using Manero.Interfaces;
using Manero.Models.Entities;

namespace Manero.Models.BaseModels
{
    public abstract class Order : IOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public string UserId { get; set; } = null!;
        public decimal OrderTotal { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatusEntity OrderStatus { get; set; } = null!;
    }
}
