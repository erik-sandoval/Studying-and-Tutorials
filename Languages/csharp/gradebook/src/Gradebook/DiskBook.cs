using System;
using System.IO;

namespace Gradebook {
    public class DiskBook : Book, IBook {
        public DiskBook(string name) : base(name) {

        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade) {
            using(var writer = File.AppendText($"{Name}.txt")) {
                Console.WriteLine("here");
                if (grade <= 100 && grade >= 0) {
                    writer.WriteLine(grade);
                    if (GradeAdded != null) {
                        GradeAdded(this, new EventArgs());
                    } else {
                        throw new ArgumentException($"Invalid {nameof(grade)}");
                    }
                }
            }
        }

        public override Statistics GetStatistics() {
            var results = new Statistics();
            using(var reader = File.OpenText($"{Name}.txt")) {
                var line = reader.ReadLine();
                while (line != null) {
                    results.Add(double.Parse(line));
                    line = reader.ReadLine();
                }
            }

            return results;
        }
    }
}