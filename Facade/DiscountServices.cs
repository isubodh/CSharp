namespace facade.Discounts {

    public class DayOfWeekDiscount{

        public int GetDiscountPercentage(){
            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday ){
                return 20;
            } else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday){
                return 15;
            }
            return 0;
        }

    }

    public class FestivalDiscount{

        public int GetDiscountPercentage(){
            if(DateTime.Now.Month == 12 )
                return 20;
            return 0;
        }

    }

    public class CustomerValueDiscount{

       public int GetDiscountPercentage(Order order){
        
        if(order.customerTotal > 1000 & order.Discount < 40)
            return 10;
        return 0;    
       }    
       
    }
}