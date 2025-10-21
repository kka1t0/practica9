using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practica9
{
    class BankAccount
    {
        private string owner;
        private double balance;

        public string Owner
        {
            get { return owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Имя владельца не может быть пустым");
                }
                else
                {
                    owner = value;
                }
            }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка, баланс не может быть меньше 0");
                }
                else
                {
                    balance = value;
                }
            }
        }
        
        public void Deposit(int sum)
        {
            if (sum > 0)
            {
                Balance = Balance += sum;
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine($"{Owner}, баланс: {Balance}");
        }
        public void Withdraw(int sum)
        {
            if (sum > 0 && Balance > sum)
            {
                Balance = Balance -= sum;
            }
            else
            {
               Console.WriteLine("Ошибка, баланс меньше суммы снятия");
            }
            Console.WriteLine($"{Owner}, баланс: {Balance}");
        }
    }
}