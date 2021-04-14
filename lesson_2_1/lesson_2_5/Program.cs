using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вычисление средней температуры
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
            // Вычисление средней температуры

            // Вывод месяца
            Console.WriteLine($"Введите порядковый номер текущего месяца: ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || (1 > month) || (month > 12))
            {
                Console.WriteLine("Ошибка ввода. Введите цифры от 1 до 12");
            }
            switch (month)
            {
                case 1:
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Месяц январь");
                        Console.WriteLine("Дождливая зима");                // "Дождливая зима"
                    }
                    else
                    {
                    Console.WriteLine("Январь");
                    }
                    break;
                case 2:
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Месяц Февраль");
                        Console.WriteLine("Дождливая зима");                // "Дождливая зима"
                    }
                    else
                    {
                        Console.WriteLine("Февраль");
                    }
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    if (averageTemp < -10)
                    {
                        Console.WriteLine("Привет пингвинам!");
                    }
                    else
                    {
                        Console.WriteLine("Июнь");
                    }
                    break;
                case 7:
                    if (averageTemp < -10)
                    {
                        Console.WriteLine("Привет пингвинам!");
                    }
                    else
                    {
                        Console.WriteLine("Июль");
                    }
                    break;
                case 8:
                    if (averageTemp < -10)
                    {
                        Console.WriteLine("Привет пингвинам!");
                    }
                    else
                    {
                        Console.WriteLine("Август");
                    }
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Месяц Декабрь");
                        Console.WriteLine("Дождливая зима");                // "Дождливая зима"
                    }
                    else
                    {
                        Console.WriteLine("Декабрь");
                    }
                    break;
            // Вывод месяца
            }
            Console.ReadLine();
        }
    }
}
