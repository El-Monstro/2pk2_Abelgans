using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца (1-12):");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Праздничные дни:");
            switch (month)
            {
                case 1:
                    Console.WriteLine("1 января - Новый год");
                    Console.WriteLine("7 января - Рождество Христово");
                    break;
                case 2:
                    Console.WriteLine("23 февраля - День защитника Отечества");
                    break;
                case 3:
                    Console.WriteLine("8 марта - Международный женский день");
                    break;
                case 4:
                    Console.WriteLine("1 апреля - День смеха");
                    Console.WriteLine("12 апреля - Пасха");
                    break;
                case 5:
                    Console.WriteLine("1 мая - Праздник Весны и Труда");
                    Console.WriteLine("9 мая - День Победы");
                    break;
                case 6:
                    Console.WriteLine("12 июня - День России");
                    break;
                case 7:
                    Console.WriteLine("4 ноября - День народного единства");
                    break;
                case 8:
                    Console.WriteLine("22 августа - День Государственного флага Российской Федерации");
                    break;
                case 9:
                    Console.WriteLine("1 сентября - День знаний");
                    break;
                case 10:
                    Console.WriteLine("31 октября - Хэллоуин");
                    break;
                case 11:
                    Console.WriteLine("4 ноября - День народного единства");
                    break;
                case 12:
                    Console.WriteLine("31 декабря - Новый год");
                    Console.WriteLine("7 января - Рождество Христово");
                    break;
                default:
                    Console.WriteLine("Ошибка: введено неправильное число месяца");
                    break;
            }
        }
    }
}
