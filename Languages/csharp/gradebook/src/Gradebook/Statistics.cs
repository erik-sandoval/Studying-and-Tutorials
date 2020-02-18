using System;
using System.Collections.Generic;

namespace Gradebook {
    public class Statistics {
        public double Average { get { return Sum / Count; } }
        public double High;
        public double Low;
        public char Letter {
            get {
                return GetLetterGrade();
            }
        }
        public double Sum;
        public int Count;

        public Statistics() {
            Sum = 0.0;
            Count = 0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public void Add(double number) {
            Sum += number;
            Count += 1;

            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public char GetLetterGrade() {
            switch (Average) {
                case var d when d >= 90.0:
                    return 'A';
                case var d when d >= 80.0:
                    return 'B';
                case var d when d >= 70.0:
                    return 'C';
                case var d when d >= 60.0:
                    return 'D';
                default:
                    return 'F';
            }
        }
    }
}