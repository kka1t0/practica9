using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Задание 1 ---------");
            Person person = new Person();
            person.Name = "Егор";
            person.Age = 17;
            person.SayHello();
            Console.WriteLine();

            Console.WriteLine("--------- Задание 2 ---------");
            Phone phone = new Phone();
            phone.Brand = "nokia";
            phone.BatteryLevel = 100;
            phone.UsePhone();
            phone.UsePhone();
            Console.WriteLine();

            Console.WriteLine("--------- Задание 3 ---------");
            BankAccount bankaccount = new BankAccount();
            bankaccount.Balance = 250;
            bankaccount.Owner = "Егор";
            bankaccount.Deposit(1000);
            bankaccount.Withdraw(300);
            Console.WriteLine();

            Console.WriteLine("--------- Задание 4 ---------");
            Circle circle = new Circle();
            circle.Radius = 5;
            circle.GerArea();
            Console.WriteLine();

            Console.WriteLine("--------- Задание 5 ---------");
            Pet pet = new Pet();
            pet.PetName = "Шарик";
            pet.Energy = 30;
            pet.Play();
            pet.Rest();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
