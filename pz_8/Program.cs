using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[8, 6];

            
            char c = 'A';
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = c;
                    c++;
                }
            }

            
            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            
            for (int j = 0; j < 6; j++)
            {
                char temp = arr[0, j];
                arr[0, j] = arr[7, j];
                arr[7, j] = temp;
            }

            
            Console.WriteLine("Измененный массив:");
            PrintArray(arr);
        }


        static void PrintArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
