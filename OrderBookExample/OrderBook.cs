using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBookExample
{
    public class OrderBook
    {
        private List<Order> _orders { get; set; } = new();
        #region ExposedFuctions
        public void Add(Order order)
        {
            var corder = GetOrderByPrice(order.Price);

            if (corder is not null)
            {
                corder.IncreaseHighestPriceQty(order.Qty);
                //IncreaseHighstPriceQty(order.Qty);
            }
            else
            {
                _orders.Add(order);
            }
        }
        public void Cancel(int orderId)
        {
            var order = _orders.Find(p => p.Id == orderId) ?? throw new Exception("not found");
            _orders.Remove(order);

        }


        //"BuyQty@BuyPrice : SellQty@SellPrice"
        public List<(string, string)> GetOrders()
        {
            var groupedOrders = _orders
                                .GroupBy(o => o.OrderType)
                                .ToDictionary(
                                    g => g.Key,
                                    g => g.Key == OrderType.s
                                        ? g.OrderBy(o => o.Price).ToList()
                                        : g.OrderByDescending(o => o.Price).ToList());

            var buyOrders = groupedOrders.ContainsKey(OrderType.b) ? groupedOrders[OrderType.b] : [];
            var sellOrders = groupedOrders.ContainsKey(OrderType.s) ? groupedOrders[OrderType.s] : [];

            var result = new List<(string, string)>();

            for (int i = 0; i < Math.Max(buyOrders.Count, sellOrders.Count); i++)
            {
                var buy = i < buyOrders.Count ? $"{buyOrders[i].Qty}@{buyOrders[i].Price}" : string.Empty;
                var sell = i < sellOrders.Count ? $"{sellOrders[i].Qty}@{sellOrders[i].Price}" : string.Empty;

                result.Add(new(buy, sell));
            }
            return result;
        }

        public (string, string) GetTopOfBook()
        {
            return GetOrders().First();
        }
        #endregion

        #region privateMethods
        private Order? GetOrderByPrice(int price)
        {
            return _orders.FirstOrDefault(p => p.Price == price);
        }
        #endregion
    }
}
