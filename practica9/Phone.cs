using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practica9
{
    class Phone
    {
        private string brand;
        private int batterylevel;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Имя бренда не может быть пустым");
                }
                else
                {
                    brand = value;
                }
            }
        }

        public int BatteryLevel
        {
            get { return batterylevel; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                }
                else
                {
                    batterylevel = value;
                }
            }
        }
        public void UsePhone()
        {
            if (BatteryLevel >= 10)
            {
                BatteryLevel = BatteryLevel - 10;
                Console.WriteLine($"Телефон {Brand}, заряд {BatteryLevel}");
            }
            else
            {
                Console.WriteLine("Ошибка, начальный заряд меньше 10");
            }
        }
    }
}