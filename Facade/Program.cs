using facade;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var order1 = new Order();
order1.AddItem(1000);

Console.WriteLine($" For {order1.customerId} : {order1.orderValue()} with Discount {order1.Discount}%");

var order2 = new Order();
order2.AddItem(10000);

Console.WriteLine($" For {order2.customerId} : {order2.orderValue()} with Discount {order2.Discount}%");