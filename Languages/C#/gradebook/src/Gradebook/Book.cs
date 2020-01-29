using System;
using System.Collections.Generic;

namespace Gradebook {
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject {
        public string Name { get; set; }

        public NamedObject(string name) {
            Name = name;
        }

    }

    public interface IBook {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook {
        public Book(string name) : base(name) {}

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }

    public class InMemoryBook : Book, IBook {
        List<double> grades;
        public char Letter;

        public InMemoryBook(string name) : base(name) {
            grades = new List<double>();
            Name = name;
        }

        public override void AddGrade(double grade) {
            if (grade <= 100 && grade >= 0) {
                grades.Add(grade);

                if (GradeAdded != null) {
                    GradeAdded(this, new EventArgs());
                }
            } else {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics() {
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