using System;

namespace ConsoleApp1
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Bir person yaradildi.");
        }

        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public Person(string name, string surname, int age):this(name,surname)
        {
            Age = age;
        }


        public string Name;
        public string Surname;
        public int Age;
        public Person Father;
        public Person[] Children;
        public Car PersonCar;

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine($"{GetFullName()} {Age}");
        }

        public string GetFatherName()
        {
            return Father.Name;
        }
    }
}
