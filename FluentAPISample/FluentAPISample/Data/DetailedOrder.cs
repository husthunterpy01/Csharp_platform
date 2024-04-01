namespace FluentAPISample.Data
{
    public class DetailedOrder
    {
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public int numOrders { get; set; }
        public double Price { get; set; }
        public byte Discount { get; set; }

        // Relationship
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
