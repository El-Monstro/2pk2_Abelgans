using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_18

enum Marks
{
    Отлично = 5,
    Хорошо = 4,
    Удовлетворительно = 3,
    Неудовлетворительно = 2,
    ОченьПлохо = 1
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите отметку: ");

        int mark;
        if (int.TryParse(Console.ReadLine(), out mark))
        {
            switch (mark)
            {
                case (int)Marks.Отлично:
                    Console.WriteLine($"Характеристика отметки {mark}: {Marks.Отлично}");
                    break;
                case (int)Marks.Хорошо:
                    Console.WriteLine($"Характеристика отметки {mark}: {Marks.Хорошо}");
                    break;
                case (int)Marks.Удовлетворительно:
                    Console.WriteLine($"Характеристика отметки {mark}: {Marks.Удовлетворительно}");
                    break;
                case (int)Marks.Неудовлетворительно:
                    Console.WriteLine($"Характеристика отметки {mark}: {Marks.Неудовлетворительно}");
                    break;
                case (int)Marks.ОченьПлохо:
                    Console.WriteLine($"Характеристика отметки {mark}: {Marks.ОченьПлохо}");
                    break;
                default:
                    Console.WriteLine("Некорректное значение");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}
