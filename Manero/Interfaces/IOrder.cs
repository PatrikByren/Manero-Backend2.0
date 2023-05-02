namespace Manero.Interfaces
{
    public interface IOrder
    {
        public DateTime OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public string UserId { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
