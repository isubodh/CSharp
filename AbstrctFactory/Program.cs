// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using AbstractFactory;

Console.WriteLine("Hello, World!");

var  ukShippingCartPurchaseFactory = new UKShippingCartPurchaseFactory();
var  usShippingCartPurchaseFactory = new USShippingCartPurchaseFactory();


var shoppingCarts = new List<ShoppingCart>(){
    new ShoppingCart(ukShippingCartPurchaseFactory, 200),
    new ShoppingCart(usShippingCartPurchaseFactory, 500)
};

foreach(var shoppingCart in shoppingCarts ){
    shoppingCart.CalculateCost();
}

