// See https://aka.ms/new-console-template for more information
using OrderBookExample;

var model = new OrderBook();
model.Add(new(id: 1, orderType: OrderType.s, price: 5, qty: 3));
model.Add(new(id: 2, orderType: OrderType.s, price: 45, qty: 10));
model.Add(new(id: 3, orderType: OrderType.b, price: 25, qty: 8));
model.Add(new(id: 4, orderType: OrderType.b, price: 30, qty: 6));
model.Add(new(id: 5, orderType: OrderType.b, price: 10, qty: 4));            

var result = model.GetTopOfBook();
var AllOrders = model.GetOrders();

Console.WriteLine("----------------Top Of The Book Orders---------------");
Console.WriteLine("");
Console.WriteLine($"  {result.Item1} : {result.Item2}");


Console.WriteLine("");
Console.WriteLine("-----------------------All Orders--------------------");
Console.WriteLine("");
Console.WriteLine("Buy Side  Sell Side");
Console.WriteLine("--------  ---------");

foreach (var item in AllOrders)
{
    Console.WriteLine($"  {item.Item1}      {item.Item2}");
}
