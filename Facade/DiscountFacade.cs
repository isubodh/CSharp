using facade.Discounts;

namespace facade {

    public class CalculateDiscount{
        private DayOfWeekDiscount _dayOfWeekD = new DayOfWeekDiscount();
        private FestivalDiscount _festivalD = new FestivalDiscount();
        private CustomerValueDiscount _customerValueD = new CustomerValueDiscount();
        public CalculateDiscount(Order order){

            order.Discount += _dayOfWeekD.GetDiscountPercentage();
            order.Discount += _festivalD.GetDiscountPercentage();
            order.Discount += _customerValueD.GetDiscountPercentage(order);
            
        }
    }
}