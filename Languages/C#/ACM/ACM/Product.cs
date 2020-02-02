using System.Collections.Generic;

namespace ACM {
    public class Product {

        public Product() {

        }

        public Product(int productId) {
            ProductId = productId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; private set; }
        public decimal? price { get; set; }

        public List<Product> Retrieve() {

            return new List<Product>();
        }

        public bool Save() {
            return true;
        }

        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name))isValid = false;

            return isValid;
        }
    }
}