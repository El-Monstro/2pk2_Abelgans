using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            double spacePercentage = GetSpacePercentage(input);

            Console.WriteLine($"Процент пробелов в строке: {spacePercentage:F2}%");

            Console.ReadKey();
        }

        static double GetSpacePercentage(string input)
        {
            int spaceCount = 0;

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            double spacePercentage = (double)spaceCount / input.Length * 100;

            return spacePercentage;
        }
    }
    
}
