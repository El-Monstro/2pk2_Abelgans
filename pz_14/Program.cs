using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер элемента n: ");
            int n = int.Parse(Console.ReadLine());

            int a1 = 2;
            int d = 6;

            int nthElement = GetNthElement(a1, d, n);

            Console.WriteLine($"n-й элемент арифметической прогрессии: {nthElement}");

            Console.ReadKey();
        }

        static int GetNthElement(int a1, int d, int n)
        {
            if (n == 1)
            {
                return a1;
            }

            return GetNthElement(a1 + d, d, n - 1);
        }
    }
    
}
