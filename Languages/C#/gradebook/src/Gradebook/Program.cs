using System;
using System.Collections.Generic;

namespace Gradebook {
    class Program {
        static void Main(string[] args) {

            var book = new Book("Erik's Gradebook");

            while (true) {
                Console.WriteLine("Please input a grade between 0 and 100");
                var input = Console.ReadLine();

                if (input == "q") {
                    break;
                }

                try {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                } catch (ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                } catch (FormatException ex) {
                    Console.WriteLine(ex.Message);
                }

            }

            var stats = book.GetStatistics();
            Console.WriteLine($"Average score of grades is {stats.Average:N2}");
            Console.WriteLine($"Lowest score of grades is {stats.Low:N2}");
            Console.WriteLine($"Highest score of grades is {stats.High:N2}");
            Console.WriteLine($"Student recieved an {book.Letter}");

        }
    }
}