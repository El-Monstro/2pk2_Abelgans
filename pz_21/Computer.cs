using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Computer
    {
        public int ID { get; set; }
        public int totalHDDMemory { get; set; }
        public int processorFrequency {  get; set; }

        public Computer(int ID, int totalHDDMemory, int processorFrequency)
        {
            this.ID = ID;
            this.totalHDDMemory = totalHDDMemory;
            this.processorFrequency = processorFrequency;
        }

        public void GetCompName()
        {
            Console.WriteLine($"ID:{ID}\n Память в ГБ:{totalHDDMemory}\n Частота процессора:{processorFrequency}");
        }



    }

}
