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
        public void Add(Order order)
        {
            // if price is the same must add to it otherwise must create new row
            var corder = Orders.Find(p => p.Price == order.Price);
            if (corder is not null)
            {
                corder.Price += order.Price;
                corder.Qty += order.Qty;
            }
            else
            {
                Orders.Add(order);
            }
        }

        public void Cancel(int orderId)
        {
            var order = Orders.Find(p => p.Id == orderId) ?? throw new Exception("not found");
            Orders.Remove(order);

        }
        public List<BuySell> GetTopOfBook()
        {
            var groupedOrders = Orders
                                .GroupBy(o => o.OrderType)
                                .ToDictionary(
                                    g => g.Key,
                                    g => g.Key == OrderType.s
                                        ? g.OrderByDescending(o => o.Price).ToList()
                                        : g.OrderBy(o => o.Price).ToList());

            var buyOrders = groupedOrders.ContainsKey(OrderType.b) ? groupedOrders[OrderType.b] : new List<Order>();
            var sellOrders = groupedOrders.ContainsKey(OrderType.s) ? groupedOrders[OrderType.s] : new List<Order>();

            var result = new List<BuySell>();

            for (int i = 0; i < Math.Max(buyOrders.Count, sellOrders.Count); i++)
            {
                var buy = i < buyOrders.Count ? $"{buyOrders[i].Qty}@{buyOrders[i].Price}" : string.Empty;
                var sell = i < sellOrders.Count ? $"{sellOrders[i].Qty}@{sellOrders[i].Qty}" : string.Empty;

                result.Add(new BuySell { Buy = buy, Sell = sell });
            }
            return result;


        }
        public List<Order> Orders { get; set; } = [

            new() { Id = 1, OrderType = OrderType.s, Price = 15, Qty = 5  },
            new() { Id = 1, OrderType = OrderType.s, Price = 5,  Qty = 3  },
            new() { Id = 1, OrderType = OrderType.s, Price = 45, Qty = 10 },
            new() { Id = 1, OrderType = OrderType.b, Price = 25, Qty = 8  },
            new() { Id = 1, OrderType = OrderType.b, Price = 30, Qty = 6  },
            new() { Id = 1, OrderType = OrderType.b, Price = 10, Qty = 4  }
        ];
    }
}
