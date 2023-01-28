namespace Builder{

    public class ProductPricing {
        private PricingCaseBuilder? _builder;
        
        public void Pricing(PricingCaseBuilder builder){
            _builder = builder;

            _builder.BuildClient();
            _builder.BuildProduct();
        }

            public void Show()
        {
            Console.WriteLine(_builder?.pricingCase.ToString());
        }
    }
}