namespace AbstractFactory {


    public interface IShippingCostService {
         decimal ShippingCost {get ; }
    }

    public class UKShippingCostService : IShippingCostService {
        public decimal ShippingCost => 11;
    }
    
    public class USShippingCostService : IShippingCostService {
        public decimal ShippingCost => 22;
    }
}