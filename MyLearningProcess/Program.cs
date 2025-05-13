using System;
using System.IO;
using MyLearningProcess.Entities;

namespace MyLearningProcess {
    //This project was created to show my process of studying and all that i learned about coding
    //Exercise IComparable
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\in.txt"; 

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Student> student = new List<Student>();
                    while (!sr.EndOfStream) {
                        student.Add(new Student(sr.ReadLine()));
                    }
                    student.Sort();
                    foreach(Student s in student) {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (IOException ex) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }

        }
    }
}