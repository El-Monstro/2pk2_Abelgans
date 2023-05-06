using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            int sum;
            GetSquareSumm(m, n, out sum);

            Console.WriteLine($"Сумма квадратов простых чисел на интервале ({m}, {n}): {sum}");

            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void GetSquareSumm(int m, int n, out int summ)
        {
            summ = 0;

            for (int i = m; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    summ += i * i;
                }
            }
        }
    }
}
