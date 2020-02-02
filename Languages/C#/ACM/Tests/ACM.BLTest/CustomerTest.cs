using System;
using Xunit;

namespace ACM.BLTest {
    public class CustomerTest {
        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        [Fact]
        public void TestName() {
            var customer = new Customer { FirstName = "Bilbo", LastName = "Baggins" };

            string expected = "Baggins, Bilbo";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNameAuth() {
            var customer = new Customer { FirstName = "Bilbo", };

            string expected = "Bilbo";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest() {
            var customer1 = new Customer { FirstName = "Bilbo" };
            Customer.InstanceCount += 1;
            var customer2 = new Customer { FirstName = "Frodo" };
            Customer.InstanceCount += 1;
            var customer3 = new Customer { FirstName = "Rosie" };
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);
        }
    }
}