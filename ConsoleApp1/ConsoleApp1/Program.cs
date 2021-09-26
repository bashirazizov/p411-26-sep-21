using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonym object
            //var p1 = new
            //{
            //    name = "Mamed",
            //    surname = "Aliyev",
            //    age = 21
            //};

            //var p2 = new
            //{
            //    name = "Kamran",
            //    surname = "Mammadov",
            //    age = 21
            //};

            //Console.WriteLine($"{p1.name} {p1.surname} yas: {p1.age}");
            //Console.WriteLine($"{p2.name} {p2.surname} yas: {p2.age}");
            #endregion

            #region Class / Object instancialization / Agregation 
            //Person p2 = new Person();
            //p2.Name = "Kamran";
            //p2.Surname = "Mammadov";
            //p2.Age = 21;

            //p1.PrintFullName();
            //p2.PrintFullName();

            //Person father1 = new Person();
            //father1.Name = "Cavid";
            //father1.Surname = "Aliyev";
            //father1.Age = 55;

            //Person child1 = new Person();
            //child1.Name = "Mamed";
            //child1.Surname = "Aliyev";
            //child1.Age = 21;

            //Person child2 = new Person();
            //child2.Name = "Sebine";
            //child2.Surname = "Aliyeva";
            //child2.Age = 25;

            //child1.Father = father1;
            //child2.Father = father1;

            //Person[] children = { child1, child2 };

            //father1.Children = children;

            //Console.WriteLine(child1.GetFatherName());
            //Console.WriteLine(child2.GetFatherName());

            //foreach (Person child in father1.Children)
            //{
            //    Console.WriteLine(child.Name + ", ");
            //}

            //Car car1 = new Car();
            //car1.Make = "BMW";
            //car1.Model = "f10";
            //car1.Year = 2019;

            //father1.PersonCar = car1;
            //Console.WriteLine(father1.PersonCar.Make);

            #endregion

            #region Constructors
            //Person pers1 = new Person("Mamed","Alivev");
            //Person pers2 = new Person("Mikayil","Mushviq",52);
            //Person pers3 = new Person();
            //User myUser = new User("Mamed", "Aliyev", 24);
            #endregion

            #region Card Task
            //Card card1 = new Card("Visa","AZN",1000.00,"1243124123123123");
            //Card card2 = new Card("Master","USD",400.00,"3921873981273");
            //Card[] cards = { card1, card2 };
            //myUser.Cards = cards;
            //Console.WriteLine(myUser.GetBalance("Master"));
            //myUser.Withdraw("master",300);
            //Console.WriteLine(myUser.GetBalance("Master"));
            #endregion

            #region Inheritance
            //Student st1 = new Student("Mamed","Aliyev",13, 4.2);
            //st1.PrintFullInfo();
            //st1.Name = "Mamed";
            //st1.Surname = "Aliyev";
            //st1.GPA = 4.2;
            //Worker wk1 = new Worker();
            //wk1.Name = "Mamed";
            //wk1.Surname = "Aliyev";
            //wk1.Salary = 1000;
            //Console.WriteLine(st1.GetNameAndAcademicResult());
            #endregion
        }

        #region ConcatWords
        static string ConcatWords(params string[] words)
        {
            string result="";
            foreach (string item in words)
            {
                if (item == words[words.Length-1])
                {
                    result+=item;
                }
                else
                {
                    result+=item + ", ";
                }
            }
            return result;
        }
        #endregion
    }
}
