using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            byte[] bytes = new byte[8];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)(i + 1);
            }

            Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);

            Console.WriteLine("Bytes:");
            foreach (byte b in bytes)
            {
                Console.Write("{0} ", b);
            }

            Console.WriteLine("\n\nArray:");
            foreach (int a in array)
            {
                Console.Write("{0} ", a);
            }
            //

            Console.ReadKey();
        }
    }
    
}
