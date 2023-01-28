namespace Builder {

    public abstract class PricingCaseBuilder {
        public PricingCase pricingCase {get; private set;}

        public PricingCaseBuilder(string pricingCaseType){
            pricingCase = new PricingCase(pricingCaseType);
        }
    

        public abstract void BuildClient();

        public abstract void BuildProduct();

    }

}