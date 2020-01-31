using System;
using Problems;
using Xunit;

namespace test {
    public class UnitTest1 {
        [Fact]
        public void Test1() {

            Assert.Equal(ProblemsRepo.FormatPhoneNumber(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }), "(123) 456-7890");
        }
    }
}