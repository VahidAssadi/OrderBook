namespace OrderBookExample
{
    public class MessageHandler
    {
        // [('a', 'b', 1, 2, 3), ('c', 1)]
        private readonly IOrderBook _orderBook;
        public MessageHandler(IOrderBook orderBook)
        {
            _orderBook = orderBook;
        }
        public void Add(Order order)
        {
            _orderBook.Add(new Order(order.Id, order.OrderType, order.Price, order.Qty));
        }

        public void Cancel(int orderId)
        {
            _orderBook.Cancel(orderId);
        }
    }
}
