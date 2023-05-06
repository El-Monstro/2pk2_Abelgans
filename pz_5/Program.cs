using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int start = 0;
            int end = 90;
            int step = 5;

            for (int i = start; i <= end; i += step)
            {
                Console.WriteLine(i);
            }
       

            char startChar = 'b';
            int n = 6;

            for (int i = 0; i < n; i++)
            {
                Console.Write(startChar + " ");
                startChar++;
            }
        }

    }
}
