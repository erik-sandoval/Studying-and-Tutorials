using System;

namespace ACM {
    public class Customer {
        public int customerId {
            get;
            private set;
        }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public string FullName {
            get {
                return $"{LastName},{FirstName}";
            }
        }
    }
}