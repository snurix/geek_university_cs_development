using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание не выполнил, не хватило вермени, массив нужно было использовать String '10' не получится отобразить
            Char[,] board = new Char[11, 11];
            for (int i = 0; i < 10; i++)
            {
                board[i+1, 0] = Convert.ToChar(i + 65);
            }


            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
