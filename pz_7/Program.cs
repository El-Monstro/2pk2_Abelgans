using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            int[] filteredArray = new int[50];
            Random rand = new Random();

            // заполнение
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101);
            }

            // копирование элементов в новый массив
            int sum = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= -10 && array[i] <= 10)
                {
                    filteredArray[j] = array[i];
                    sum += Math.Abs(array[i]); 
                    j++;
                }
            }

            // вывод результатов
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\nОтфильтрованный массив:");
            for (int i = 0; i < j; i++)
            {
                Console.Write(filteredArray[i] + " ");
            }
            Console.WriteLine("\n\nСумма по модулю: " + sum);
        }
    }
}
