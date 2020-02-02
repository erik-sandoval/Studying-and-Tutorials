using System;
using System.Collections.Generic;

namespace ACM {
    public class Order {
        public Order() {

        }

        public Order(int orderId) {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }

        public int OrderId { get; private set; }

        public List<Order> Retrieve() {

            return new List<Order>();
        }

        public bool Save() {
            return true;
        }

        public bool Validate() {
            var isValid = true;

            // if (string.IsNullOrWhiteSpace(OrderId))isValid = false;
            return isValid;
        }

    }

}