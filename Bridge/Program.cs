using menu.service;
Console.WriteLine("Hello, World!");

var couponD = new DiwaliDiscount(15);
var couponR = new RegulaVisterDiscount(5);

var myMenu = new VegMenu(100, couponD);
Console.WriteLine($"Bill amount = {myMenu.getBill()}");

var myMenu1 = new VegMenu(100, couponR);
Console.WriteLine($"Bill amount = {myMenu1.getBill()}");

var myMenu2 = new NonVegMenu(200, couponD);
Console.WriteLine($"Bill amount = {myMenu2.getBill()}");

var myMenu3 = new NonVegMenu(200, couponR);
Console.WriteLine($"Bill amount = {myMenu3.getBill()}");
