using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите любые символы: ");
            string s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
