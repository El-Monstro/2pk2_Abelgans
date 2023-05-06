﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] words = { { "Hello", "Привет" }, { "World", "Мир" }, { "!", "!" } };

            int rows = words.GetLength(0);
            int cols = words.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(words[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}


