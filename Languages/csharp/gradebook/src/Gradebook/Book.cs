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

            var results = new Statistics();

            foreach (double number in grades) {
                results.Add(number);
            }

            return results;
        }
    }
}