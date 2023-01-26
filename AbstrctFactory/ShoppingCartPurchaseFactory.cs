namespace AbstractFactory {

    public interface IShoppingCartPurchaseFactory {
        IDiscountService createDiscountService();
        IShippingCostService createShippingCostService();
    }

    public class UKShippingCartPurchaseFactory : IShoppingCartPurchaseFactory {
        public IDiscountService createDiscountService() {
            return new UKDicountService();
        }

        public IShippingCostService createShippingCostService(){
            return new UKShippingCostService();
        }
    }

    public class USShippingCartPurchaseFactory : IShoppingCartPurchaseFactory {
        public IDiscountService createDiscountService() {
            return new USDiscountService();
        }

        public IShippingCostService createShippingCostService(){
            return new USShippingCostService();
        }
    }
}