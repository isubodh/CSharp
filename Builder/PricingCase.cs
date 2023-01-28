using System.Text;

namespace Builder {

    public class PricingCase {
        private List<String> _products = new List<String>();
        private readonly string _pricingCaseType ;

        public PricingCase(string pricingCaseType){
            _pricingCaseType = pricingCaseType;
        }

        public void AddProduct(string pricingProduct){
            _products.Add(pricingProduct);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var product in _products ){
                sb.Append($"Pricing Case [{_pricingCaseType}] has product {product} ");
            }
            return sb.ToString();
        }
    }
}