using System;
using System.Collections.Generic;

namespace Gradebook {
    class Program {
        static void Main(string[] args) {

            var book = new DiskBook("Erik's Gradebook");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();
            Console.WriteLine($"Average score of grades is {stats.Average:N2}");
            Console.WriteLine($"Lowest score of grades is {stats.Low:N2}");
            Console.WriteLine($"Highest score of grades is {stats.High:N2}");

            static void OnGradeAdded(object sender, EventArgs e) {
                Console.WriteLine("Grade Added");
            }
        }

        private static void EnterGrades(Book book) {
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
                } finally {
                    Console.WriteLine("**");
                }
            }
        }
    }
}