using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class Pet
    {
        private string petname;
        private int energy;

        public string PetName
        {
            get { return petname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Имя петомца не может быть пустым");
                }
                else
                {
                    petname = value;
                }
            }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                }
                else
                {
                    energy = value;
                }
            }
        }
     
        public void Play()
        {
            if (Energy > 20)
            {
                Energy = Energy - 20;
                Console.WriteLine($"{PetName} играет, энергия: {Energy}");
            }
            else
            {
                Console.WriteLine("Начальная энергия петомца меньше 20");
            }
        }
        public void Rest()
        {
            if (Energy <= 70)
            {
                Energy = Energy + 30;
                Console.WriteLine($"{PetName} отдыхает, энергия: {Energy}");
            }
            else
            {
                Console.WriteLine("Начальная энергия петомца больше 70");
            }
        }
    }
}