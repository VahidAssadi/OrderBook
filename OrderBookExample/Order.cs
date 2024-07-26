namespace OrderBookExample
{
    public class Order
    {
        public Order(int id, OrderSide orderType, int price, int qty)
        {
            Id = id;
            Price = price;
            Qty = qty;
            OrderType = orderType;
        }
        public int Id { get; private set; }
        public int Price { get; private set; }
        public int Qty { get; private set; }
        public OrderSide OrderType { get; private set; }

        public void IncreaseHighestPriceQty(int qty)
        {
            this.Qty += qty;
        }

        public void DecreaseHighestPriceQty(int qty)
        {
            this.Qty -= qty;
        }
    }
}
