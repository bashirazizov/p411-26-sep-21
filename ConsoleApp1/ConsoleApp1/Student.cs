using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:Person
    {
        public double GPA;
        public string Major;

        public Student(string name, string surname):base(name,surname) { }
        public Student(string name, string surname,int age, double gpa):base(name,surname,age) {
            GPA = gpa;
        }


        public string GetNameAndAcademicResult()
        {
            return $"{GetFullName()} {GPA}";
        }

        public override void PrintFullInfo()
        {
            base.PrintFullInfo();
            Console.WriteLine($"GPA: {GPA}");
        }
    }
}
