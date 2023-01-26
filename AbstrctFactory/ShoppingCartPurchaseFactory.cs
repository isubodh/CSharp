namespace AbstractFactory {

    public interface IShoppingCartPurchaseFactory {
        IDiscountService createDiscountService();
        IShippingCostService createShippingCostService();
    }

    public class UKShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory {
        public IDiscountService createDiscountService() {
            return new UKDicountService();
        }

        public IShippingCostService createShippingCostService(){
            return new UKShippingCostService();
        }
    }

    public class USShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory {
        public IDiscountService createDiscountService() {
            return new USDiscountService();
        }

        public IShippingCostService createShippingCostService(){
            return new USShippingCostService();
        }
    }
}