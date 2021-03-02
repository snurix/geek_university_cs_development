using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arrBook = new string[5, 2] 
            { 
                { "Петров А.А.\t", "petrov@mail.ru" }, { "Иванов А. А.\t", "d@mail.ru" }, { "Сидоров А. А.\t", "d@mail.ru" }, {"Васильев А. А.\t", "a@mail.ru"}, {"Смирнов А. А.\t", "s@mail.ru"} 
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{arrBook[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
