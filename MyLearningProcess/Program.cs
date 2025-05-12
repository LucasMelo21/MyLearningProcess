using System;
using System.IO;
using MyLearningProcess.Entities;

namespace MyLearningProcess {
    //This project was created to show my process of studying and all that i learned about coding
    //Learning IComparable
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\in.txt"; 

            try {
                using(StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
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