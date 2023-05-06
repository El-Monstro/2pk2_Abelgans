using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            int upperCount = input.Count(char.IsUpper);
            int lowerCount = input.Count(char.IsLower);
            int spaceCount = input.Count(char.IsWhiteSpace);
            int punctCount = input.Count(char.IsPunctuation);

            Console.WriteLine($"Заглавных букв: {upperCount}");
            Console.WriteLine($"Строчных букв: {lowerCount}");
            Console.WriteLine($"Пробелов: {spaceCount}");
            Console.WriteLine($"Символов пунктуации: {punctCount}");

            Console.ReadKey();
        }
    }
}
