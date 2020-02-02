using System;
using System.Collections.Generic;

namespace ACM {
    public class Customer {

        public Customer() {

        }

        public Customer(int customerId) {
            CustomerId = customerId;
        }
        public int CustomerId {
            get;
            private set;
        }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public string FullName {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        public Customer Retrieve(int customerId) {

            return new Customer();
        }

        public List<Customer> Retrieve() {

            return new List<Customer>();
        }

        public bool Save() {
            return true;
        }

        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))isValid = false;

            return isValid;
        }
    }
}