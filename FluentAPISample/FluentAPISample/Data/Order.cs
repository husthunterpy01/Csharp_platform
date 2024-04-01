namespace FluentAPISample.Data
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int OrderStatus { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Phone { get; set; }

        public ICollection<DetailedOrder> DetailedOrders { get; set; }
        public Order()
        {
            DetailedOrders = new List<DetailedOrder>();
        }
    }
}
