using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine($"Введите размер массива: ");
            int arrSize;
            while (!int.TryParse(Console.ReadLine(), out arrSize))
            {
                Console.WriteLine("Ошибка ввода. Повторите попытку");
            }
            int[,] Arry = new int[arrSize, arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    Arry[i, j] = rand.Next(10);
                    Console.Write($"{Arry[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Элементы двумерного массива по диагонали ");
            for (int k = 0; k < arrSize; k++)
            {
                for (int h = 0; h < arrSize; h++)
                {
                    if (k == h)
                    {
                        Console.Write($"{Arry[k, h]} ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
