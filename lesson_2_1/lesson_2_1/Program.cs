using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_1
{
    class Program
    {
        static void Main(string[] args)
        {                      
            Console.WriteLine($"Введите минимальную температуру за сутки: ");
            float minTemp;
            while (!float.TryParse(Console.ReadLine(), out minTemp))
            {
                Console.WriteLine("Ошибка ввода. Введите минимальную температуру за сутки (формат ввода 'xx,xx')");
            }
            Console.WriteLine($"Введите максимальную температуру за сутки: ");
            float maxTemp;
            while (!float.TryParse(Console.ReadLine(), out maxTemp))
            {
                Console.WriteLine("Ошибка ввода. Введите минимальную температуру за сутки (формат ввода 'xx,xx')");
            }
            float averageTemp;
            averageTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Среднесуточная температура: {averageTemp}");
            Console.ReadLine();
        }
    }
}
