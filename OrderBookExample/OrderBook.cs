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
        public void Add(MessageType messageType, Order order)
        {

        }

        public void Cancel(MessageType messageType, int orderId)
        {
        }
        public IEnumerable<Order> GetTopOfBook()
        {
            // Buy      Sell           
            // 4@10     18@16   <-------- Top of Book
            // 3@8      2@20 
            // 3@2      2@24 


            throw new NotImplementedException();
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
