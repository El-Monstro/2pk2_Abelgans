using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = @"
            1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0
            09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76
            2 RU161110-466130 PACK19651968 1 Софья назаретян +7 (918) 398-07-81 Наличные Плюс 0
            09:00 - 13:00 Краснодар, Базовская, Дом д.61
            3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0
            09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52
            4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0
             09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19
            5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0
            09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19
            6 RU161104-298585 PACK19514804 3 Роман +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00
            Краснодар, фурманова, Дом 62 9.11
        ";

            
            Regex regex = new Regex(@"([А-Я][а-я]+) ([А-Я][а-я]+)");
           
            string[] names = new string[0];
      
            foreach (Match match in regex.Matches(text))
            {
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = match.Value;
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
