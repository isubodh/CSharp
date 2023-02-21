namespace Stratagy {

    public abstract class Print {

        public abstract void print(Orders orders);
    }

    public class printJson : Print {

        public override void print(Orders orders){
            Console.WriteLine($"Printing orders {orders.ToString()} in JSON");
        }
    }

    public class printXML : Print {

        public override void print(Orders orders){
            Console.WriteLine($"Printing orders {orders.ToString()} in XML");
        }
    }

    public class printTXT : Print {

        public override void print(Orders orders){
            Console.WriteLine($"Printing orders {orders.ToString()} in Text");
        }
    }
}