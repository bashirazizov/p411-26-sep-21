using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Card
    {
        public Card()
        { }

        public Card(string name, string currency, double balance, string number)
        {
            Name = name;
            Currency = currency;
            Balance = balance;
            Number = number;
        }

        public string Name;
        public string Currency;
        public double Balance;
        public string Number;

        public void Withdraw(double amount)
        {
            if (amount<=Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Take your {amount} {Currency}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }
    }
}
