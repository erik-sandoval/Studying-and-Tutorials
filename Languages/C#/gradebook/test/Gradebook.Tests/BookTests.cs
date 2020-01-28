using System;
using Xunit;

namespace Gradebook.Tests {
    public class BookTests {
        [Fact]
        public void BookCalculatesAnAverageGrade() {
            var book = new Book("Test Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(32.2);

            var result = book.GetStatistics();

            Assert.Equal(32.2, result.Low);
            Assert.Equal(90.5, result.High);
            Assert.Equal(70.6, result.Average, 1);
            Assert.Equal('C', book.Letter);
        }
    }
}