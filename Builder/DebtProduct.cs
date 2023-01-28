namespace Builder {
    public class DebtProduct : PricingCaseBuilder {
        public DebtProduct() : base("Debt"){
        }

        public override void BuildClient(){
            pricingCase.AddProduct("Saby Inc");
        }

        public override void BuildProduct(){
            pricingCase.AddProduct("Overdraft");
        }
    }
}