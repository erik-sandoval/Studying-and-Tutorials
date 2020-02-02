using System.Collections.Generic;

namespace ACM {
    public class OrderItem {

        public OrderItem() {

        }

        public OrderItem(int orderItemId) {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal? price { get; set; }

        public List<Product> Retrieve() {

            return new List<Product>();
        }

        public bool Save() {
            return true;
        }

        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Product))isValid = false;
            return isValid;
        }
    }
}