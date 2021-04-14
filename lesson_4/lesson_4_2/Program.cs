using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        // числа в массив
        // сложение чисел в массиве
        // вывод сум
        {
            Read();
        }
        static Read()
        {
            Console.WriteLine($"Введите набор чисел, разделенных пробелом: ");
            string[] strarr = Console.ReadLine().Split(' ');
            string[] resultarr = strarr.Where(x => Regex.IsMatch(x, @"^\d+$")).ToArray();
            return resultarr;
        }
        static Sum()
        {
            for (int i = 0; i < size; i++)
                if ((A1[i] >= d1) && (A1[i] <= d2))
                {
                    sum += A1[i];
                }
            Console.WriteLine("Сумма = {0} ", sum);
        }

    }
}
