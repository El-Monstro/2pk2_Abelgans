using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальный пробег спортсмена: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите желаемый пробег спортсмена: ");
            double y = double.Parse(Console.ReadLine());

            int day = 1;
            while (x < y)
            {
                x *= 1.1;  
                day++; 
            }

            Console.WriteLine("Пробег спортсмена достигнет значения {0} км на {1}-й день", y, day);
        }
    }
}
