using System;
using System.Collections.Generic;

namespace Gradebook {
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class Book {
        List<double> grades;
        public string Name;
        public char Letter;

        public Book(string name) {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade) {
            if (grade <= 100 && grade >= 0) {
                grades.Add(grade);

                if (GradeAdded != null){
                    GradeAdded(this, new EventArgs());
                }
            } else {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public event GradeAddedDelegate GradeAdded;

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

            switch (Average) {
                case var d when d >= 90.0:
                    Letter = 'A';
                break;
                case var d when d >= 80.0:
                    Letter = 'B';
                break;
                case var d when d >= 70.0:
                    Letter = 'C';
                break;
                case var d when d >= 60.0:
                    Letter = 'D';
                break;
                default:
                    Letter = 'F';
                    break;
            }

            return new Statistics(Average, highGrade, lowGrade);
        }
    }
}