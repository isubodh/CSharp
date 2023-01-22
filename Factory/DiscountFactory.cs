namespace FactoryMethod {

    public abstract class DiscountFactory {
        public abstract DiscountService createDiscountService();
    } 

    public class CountryDiscountFactory : DiscountFactory{

        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier){
            _countryIdentifier = countryIdentifier;
        }
        public override DiscountService createDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }
    public class CodeDiscountFactory : DiscountFactory{
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code){
            _code = code;
        }
        public override DiscountService createDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}