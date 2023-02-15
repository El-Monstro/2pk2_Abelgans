using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Computer
    {
        public int ID { get; set; }
        public int totalHDDMemory { get; set; }
        public int processorFrequency { get; set; }

        public int AllHDD { get; set; }

        private int frequency;
        public int Frequency
        {
            get { return frequency; }
            set
            {
                if (value <= 1.5 || value >= 5)

                    Console.WriteLine("Ошибка. Частота должна быть в диапазоне от 1.5 до 5");
                frequency = value;
 
            }
   
        }
        public Computer(int ID, int totalHDDMemory, int processorFrequency, int AllHDD)
        {
            this.ID = ID;
            this.totalHDDMemory = totalHDDMemory;
            this.processorFrequency = processorFrequency;
            this.AllHDD = AllHDD;

        }


        public void GetCompName()
        {
            Console.WriteLine($"ID:{ID}\nПамять в ГБ:{totalHDDMemory}\nЧастота процессора:{processorFrequency}\nОбщая память всех компов: {AllHDD}");
            
        }

    }
}
