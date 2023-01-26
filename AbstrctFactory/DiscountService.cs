namespace AbstractFactory {
    public interface IDiscountService{
        int DiscountPercentage{ get;}
    }

    public class UKDicountService : IDiscountService {
        public int DiscountPercentage => 10;
    }
    public class USDiscountService : IDiscountService {
        public int DiscountPercentage => 15;
    }
}