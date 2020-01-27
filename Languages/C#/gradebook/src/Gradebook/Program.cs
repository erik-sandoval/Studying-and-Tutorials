using System;
using System.Collections.Generic;

namespace Gradebook {
    class Program {
        static void Main(string[] args) {

            var book = new Book("Erik's Gradebook");

            book.AddGrade(89.1);
            book.AddGrade(12.5);
            book.AddGrade(34.5);
            book.AddGrade(78.32);
            book.AddGrade(52.35);

            var stats = book.GetStatistics();

            Console.WriteLine($"Average score of grades is {stats.Average:N2}");
            Console.WriteLine($"Lowest score of grades is {stats.Low:N2}");
            Console.WriteLine($"Highest score of grades is {stats.High:N2}");

        }
    }
}