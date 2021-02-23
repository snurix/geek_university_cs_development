using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка ввода. Введите целое число.");
            }
            if (number % 2 == 0)
                Console.WriteLine($"{number} - четное");
            else
                Console.WriteLine($"{number} - не четное");
            Console.ReadLine();
        }
    }
}
