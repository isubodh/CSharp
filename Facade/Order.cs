namespace facade {

    public class Order{
        public static int customerIndex = 0;
        public int customerId {get; set;}
        public int customerTotal {get; private set;}

        public int Discount {get  ; set;}
        public Order(){
            customerIndex++;
            customerId = customerIndex;
        }

        public void AddItem(int value){
            customerTotal += value;
        }

        public float orderValue(){
            new CalculateDiscount(this);            
            return  customerTotal - customerTotal * Discount /100 ;
        }
    }
}