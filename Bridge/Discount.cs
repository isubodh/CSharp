namespace menu.service {

    
    public abstract class Discount {
        public float discount = 0;

        public Discount(int discount){
            this.discount = discount / 100F;
        }
    }

    public class DiwaliDiscount : Discount {

        public DiwaliDiscount(int discount) : base (discount) {
        }
    }

    public class RegulaVisterDiscount : Discount {

        public RegulaVisterDiscount(int discount) : base (discount) {
        }
    }
}