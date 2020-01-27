using System;
using System.Collections.Generic;

namespace Gradebook {
    class Program {
        static void Main(string[] args) {

            List<double> grades = new List<double>() { 12.5, 34.5, 78.32 };

            double result = 0.0;

            foreach (double number in grades) {
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"Average score of grades is {result:N2}");

        }
    }
}