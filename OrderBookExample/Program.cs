// See https://aka.ms/new-console-template for more information
using OrderBookExample;

Console.WriteLine("Hello, World!");

var model = new OrderBook();


var res = model.GetTopOfBook();

foreach (var item in res)
{
    Console.WriteLine($"{item.Buy}   {item.Sell}");
}
