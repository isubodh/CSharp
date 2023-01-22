namespace FactoryMethod {

    public abstract class DiscountService {
        public abstract int discountPercentatge { get; } 

        public override string ToString() => GetType().Name;

    }

    public class CountryDiscountService : DiscountService{
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier){
            _countryIdentifier = countryIdentifier;
        }
        public override int discountPercentatge {
            get{
                switch (_countryIdentifier){
                    case "IN": return 20;

                    case "UK": return 10;

                    case "US": return 15;

                    default : return 0;
                }
            }
        }
    }

    public class CodeDiscountService : DiscountService {
        private readonly Guid _code;
        public CodeDiscountService(Guid code) {
            _code = code;
        }
        public override int discountPercentatge {
            //ToDo ensuce discount code is used once
            get => 25;            
        }
    }
}