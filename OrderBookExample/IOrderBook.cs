
namespace OrderBookExample
{
    public interface IOrderBook
    {
        void Add(Order order);
        void Cancel(int orderId);
        IEnumerable<(string, string)> GetOrders();
        (string, string) GetTopOfBook();
    }
}