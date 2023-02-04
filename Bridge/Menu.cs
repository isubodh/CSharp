
namespace menu.service {

    public abstract class Menu {
        public Discount _discountCoupon = null!;
        public Menu(Discount discountType){
            _discountCoupon = discountType;
        }

        public abstract float getBill();
    }

    public class VegMenu : Menu {
        private int _billAmount = 0;
        public VegMenu(int billAmount, Discount discount) : base(discount) {
            _billAmount = billAmount;
        }

        public override float getBill()
        {
            return _billAmount - _billAmount * _discountCoupon.discount ;
        }
    }

    public class NonVegMenu : Menu {
        private int _billAmount =0;
        public NonVegMenu(int billAmount, Discount discount) : base(discount) {
            _billAmount = billAmount;
        }

        public override float getBill()
        {
            return _billAmount - _billAmount * _discountCoupon.discount ;
        }
    }
}