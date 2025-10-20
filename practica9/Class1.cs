using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Имя не может быть пустым");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Age
        {
            get { return age; }
            set
            {
                if (age =< 0 && age => 120)
                {
                    Console.WriteLine("Возраст должен быть от 0 до 120!");
                }
                else
                {
                    age = value;
                }
            }
        }
        
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
        }
    }
}
