using System;
using System.Collections.Generic;

namespace Gradebook {
    public class Book {
        List<double> grades;
        string name;

        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public Statistics GetStatistics() {
            double Average = 0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double number in grades) {
                Average += number;

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
            }

            Average /= grades.Count;

            return new Statistics(Average, highGrade, lowGrade);
        }
    }
}