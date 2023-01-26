namespace AbstractFactory {

    public class ShoppingCart {
        private  IDiscountService _discountService;
        private IShippingCostService _shippingCostService;
        private int _orderCost;
        
        public ShoppingCart(IShoppingCartPurchaseFactory factory, int orderCost){
            _discountService = factory.createDiscountService();
            _shippingCostService = factory.createShippingCostService();
            _orderCost = orderCost;
        }

        public void CalculateCost(){
            Console.WriteLine($"Total Cost = " +
            $"{ _orderCost + _orderCost * _shippingCostService.ShippingCost - _discountService.DiscountPercentage/100 *_orderCost  }"
            );
        }

    }
}