using Manero.Interfaces;

namespace Manero.Models.BaseModels
{
    public class Order : IOrder
    {
        public DateTime OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public string UserId { get; set; } = null!;
        public decimal OrderTotal { get; set; }
    }
}
