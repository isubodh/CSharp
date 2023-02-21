namespace Stratagy {

    public class Orders {
        private int _orderNo;
        private int _orderVal;

        public Orders(int orderNo, int orderVal){
            _orderNo = orderNo;
            _orderVal = orderVal;
        }

        public override string ToString()
        {
            return  _orderNo + ":" + _orderVal;
        }

        public void print(Print print){
            print.print(this);
        }
    }
}