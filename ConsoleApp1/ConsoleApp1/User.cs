using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public User()
        { }

        public User(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name;
        public string Surname;
        public int Age;
        public Card[] Cards;

        public string GetBalance()
        {
            string result = "";
            foreach (Card item in Cards)
            {
                result += $"{item.Name} - {item.Balance} - {item.Currency} / ";
            }
            return result;
        }
        public string GetBalance(string name)
        {
            foreach (Card item in Cards)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    return $"{item.Name} - {item.Balance} - {item.Currency}";
                }
            }

            return "Card not found";
        }

        public void Withdraw(string name, double amount)
        {
            foreach (Card item in Cards)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    item.Withdraw(amount);
                }
            }
        }
    }
}
