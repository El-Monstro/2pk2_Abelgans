using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер строки для удаления: ");
            int lineNumber = int.Parse(Console.ReadLine());

            string filename = "file.txt";
            string[] lines = File.ReadAllLines(filename);

            if (lineNumber > 0 && lineNumber <= lines.Length)
            {
                File.WriteAllLines(filename, GetUpdatedLines(lines, lineNumber));
                Console.WriteLine($"Строка номер {lineNumber} была удалена из файла.");
            }
            else
            {
                Console.WriteLine($"Строки номер {lineNumber} не существует в файле.");
            }

            Console.ReadKey();
        }

        static string[] GetUpdatedLines(string[] lines, int lineNumber)
        {
            string[] updatedLines = new string[lines.Length - 1];

            int j = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (i + 1 != lineNumber)
                {
                    updatedLines[j] = lines[i];
                    j++;
                }
            }

            return updatedLines;
        }

    }
}
