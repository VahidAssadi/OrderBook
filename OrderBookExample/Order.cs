namespace OrderBookExample
{
    public class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public OrderType OrderType { get; set; }
    }
}
