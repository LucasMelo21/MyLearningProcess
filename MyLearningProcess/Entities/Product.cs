using System.Diagnostics;
using System.Globalization;

namespace MyLearningProcess.Entities {
    internal class Student : IComparable {
        public string Name { get; set; }
        public double ExamGrade { get; set; }
        public Student() { }

        public Student(string csvStudent) {
            string[] vect = csvStudent.Split(", ");
            Name = vect[0];
            ExamGrade = double.Parse(vect[1], CultureInfo.InvariantCulture);

        }
        public int CompareTo(object obj) {
            if (!(obj is Student)) {
                throw new ArgumentException("An error ocurred. Argument is not a student");
            }
            
            Student other = obj as Student;
            int gradeComparison = other.ExamGrade.CompareTo(ExamGrade);
            if (gradeComparison != 0) {
                return gradeComparison;
            }
            else {
                return Name.CompareTo(other.Name);
            }
        }
        public override string ToString() {
            return Name
                + ", "
                + ExamGrade.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}