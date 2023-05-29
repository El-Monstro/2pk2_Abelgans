using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    internal class Program

    {
        struct STUDENT
        {
            public string NAME;
            public int GROUP;
            public int[] SES;
        }

        static void Main(string[] args)
        {
            STUDENT[] STUD1 = new STUDENT[10];

            for (int i = 0; i < STUD1.Length; i++)
            {
                Console.WriteLine("Введите фамилию и инициалы студента" + (i + 1));
                STUD1[i].NAME = Console.ReadLine();

                Console.WriteLine("Введите номер группы для студента" + (i + 1));
                STUD1[i].GROUP = int.Parse(Console.ReadLine());

                STUD1[i].SES = new int[5];
                Console.WriteLine("Введите пять оценок для студента" + (i + 1));
                for (int j = 0; j < STUD1[i].SES.Length; j++)
                {
                    STUD1[i].SES[j] = int.Parse(Console.ReadLine());
                }
            }

            // Упорядочиваем
            var sortedStudents = STUD1.OrderBy(s => s.SES.Average()).ToArray();

            bool found = false;
            for (int i = 0; i < sortedStudents.Length; i++)
            {
                if (sortedStudents[i].SES.Average() >= 4 && sortedStudents[i].SES.Average() <= 5)
                {
                    Console.WriteLine($"Студент {sortedStudents[i].NAME} из группы {sortedStudents[i].GROUP} имеет средний балл {sortedStudents[i].SES.Average()}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Студентов с оценками 4 или 5 не найдено.");
            }
        }
    }
}
