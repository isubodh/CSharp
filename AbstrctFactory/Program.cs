// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using AbstractFactory;

Console.WriteLine("Hello, World!");

var  ukShoppingCartPurchaseFactory = new UKShoppingCartPurchaseFactory();
var  usShoppingCartPurchaseFactory = new USShoppingCartPurchaseFactory();


var shoppingCarts = new List<ShoppingCart>(){
    new ShoppingCart(ukShoppingCartPurchaseFactory, 200),
    new ShoppingCart(usShoppingCartPurchaseFactory, 500)
};

foreach(var shoppingCart in shoppingCarts ){
    shoppingCart.CalculateCost();
}

