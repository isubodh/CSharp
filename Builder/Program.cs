using Builder;

Console.WriteLine("Hello, World!");

var pc1 = new ProductPricing();

var fx = new FxProduct();
var debt = new DebtProduct();

pc1.Pricing(fx);
pc1.Show();

pc1.Pricing(debt);
pc1.Show();

