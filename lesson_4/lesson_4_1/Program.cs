using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rep();
            Console.ReadLine();
        }
        static string GetFullName()
        {
            Console.WriteLine("Введите имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();
            string FullName = firstName + " " + lastName + " " + patronymic;
            return FullName;
        }
        static string PrintFullName(string FullName)
        {
            return $"ФИО: {FullName} добавлено";
        }
        static void Rep()
        {
            for (int i = 0; i < 4; i++)
            {
                string name = GetFullName();
                string fName = PrintFullName(name);
                Console.WriteLine(fName);
            }
        }
    }
}
