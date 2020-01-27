using System;
using System.Collections.Generic;

namespace Gradebook {
    class Book {
        List<double> grades;
        string name;

        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public void ShowStatistics() {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double number in grades) {
                result += number;

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
            }

            result /= grades.Count;

            Console.WriteLine($"Average score of grades is {result:N2}");
            Console.WriteLine($"Lowest score of grades is {lowGrade:N2}");
            Console.WriteLine($"Highest score of grades is {highGrade:N2}");
        }
    }
}