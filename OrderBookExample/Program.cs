using OrderBookExample;

var model = ObjectFactory.Create();

model.Add(new(id: 1, orderType: OrderSide.sell, price: 5, qty: 3));
model.Add(new(id: 2, orderType: OrderSide.sell, price: 45, qty: 10));
model.Add(new(id: 3, orderType: OrderSide.buy, price: 25, qty: 8));
model.Add(new(id: 4, orderType: OrderSide.buy, price: 30, qty: 6));
model.Add(new(id: 5, orderType: OrderSide.buy, price: 10, qty: 4));

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
