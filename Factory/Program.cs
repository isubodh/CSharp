using FactoryMethod;

Console.WriteLine("Factory Method");
var factories = new List<DiscountFactory> {
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("IN")
};

foreach (var factory in factories){
    var discountService = factory.createDiscountService();
    Console.WriteLine($"Percentage discount : {discountService.discountPercentatge} from {discountService}");
}
