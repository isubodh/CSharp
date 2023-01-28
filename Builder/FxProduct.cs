namespace Builder {
    public class FxProduct : PricingCaseBuilder {
        public FxProduct() : base("FX"){
        }

        public override void BuildClient(){
            pricingCase.AddProduct("SabySoft Inc");
        }

        public override void BuildProduct(){
            pricingCase.AddProduct("Fx");
        }
    }
}