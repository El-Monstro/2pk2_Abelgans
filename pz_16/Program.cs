using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "file.txt";
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                if (IsStartEndSame(line))
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }

        static bool IsStartEndSame(string line)
        {
            if (line.Length > 1)
            {
                return line[0] == line[line.Length - 1];
            }

            return false;
        }
    }
    
}
