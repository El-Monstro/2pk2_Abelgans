using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Wait wait200 = new Wait(200, "Value 200 has been reached!");
            Wait wait800 = new Wait(800, "Value 800 has been reached!");

            counter.OnValueChanged += wait200.CheckValue;
            counter.OnValueChanged += wait800.CheckValue;

            counter.StartCounting();
            Console.ReadLine();
        }
    }

    class Counter
    {
        public delegate void ValueChangedEventHandler(int value);
        public event ValueChangedEventHandler OnValueChanged;

        public void StartCounting()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"Counter: {i}");
                OnValueChanged?.Invoke(i);
                Thread.Sleep(100); // для задержки в 100 миллисекунд
            }
        }
    }

    class Wait
    {
        private int _valueToWaitFor;
        private string _messageToDisplay;

        public Wait(int valueToWaitFor, string messageToDisplay)
        {
            _valueToWaitFor = valueToWaitFor;
            _messageToDisplay = messageToDisplay;
        }

        public void CheckValue(int value)
        {
            if (value == _valueToWaitFor)
            {
                Console.WriteLine(_messageToDisplay);
            }
        }
    }
    
}
