using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Можно добавить ограничение ширины консоли...
            int origWidth, width;
            int origHeight, height;
            int checkNumber = 156;
            long INN = 6200000001;
            //float coming = 0, consumption = 0;

            string check = $"Кассовый чек № {checkNumber}";
            string adress = "Адрес 390039, Рязань, ул. Ленина, 35";
            string firm = "ООО \"РиК\"";
            string inn = $"ИНН {INN}";
            string cashier = "Иванов Иван Иванович";

            origWidth = Console.WindowWidth;
            //origHeight = Console.WindowHeight;

            // Хэдер чека
            Console.SetCursorPosition(origWidth / 2 - check.Length / 2, 1); // Всесто параметра курсора y, можно использовать счетчик, не хватило времяни на реализацию...
            Console.WriteLine($"{check}");
            Console.SetCursorPosition(origWidth / 2 - firm.Length / 2, 2);
            Console.WriteLine($"{firm}");
            Console.SetCursorPosition(origWidth / 2 - inn.Length / 2, 3);
            Console.WriteLine($"{inn}");
            Console.SetCursorPosition(origWidth / 2 - adress.Length / 2, 4);
            Console.WriteLine($"{adress}");
            Console.SetCursorPosition(origWidth / 2 - DateTime.Now.ToString("F").Length / 2, 5);
            Console.WriteLine(DateTime.Now.ToString("F"));
            Console.SetCursorPosition(origWidth / 2 - cashier.Length / 2, 6);
            Console.WriteLine($"{cashier}");
            // Хэдер чека
            // Приход / Расход
            Console.WriteLine(new string('*', origWidth));
            Console.WriteLine($"Приход");
            Console.WriteLine($"Расход");
            Console.WriteLine(new string('*', origWidth));
            // Приход / Расход
            // Список товаров

            // !!!! Забыл про знаки после запятой, сейчас исправлять нет времени, постараюсь долелать до 25.02.2021

            string milk = "Молоко", teaLipton = "Чай липтон";
            float milkPrice = 50, teaLiptonPrice = 150, milkCost, teaLiptonCost;
            int milkQuantity = 1, teaLiptonQuantity = 2, ndsTeaLipton = 20, ndsMilk = 10;

            milkCost = milkPrice * milkQuantity;
            teaLiptonCost = teaLiptonPrice * teaLiptonQuantity;
            Console.WriteLine($"Товар \t\t Цена \t Кол-во \t Стоимость");
            Console.WriteLine($"{milk} \t\t {milkPrice} \t {milkQuantity} \t\t {milkCost}");
            Console.WriteLine($"НДС {ndsMilk}%");
            Console.WriteLine($"{teaLipton} \t {teaLiptonPrice} \t {teaLiptonQuantity} \t\t {teaLiptonCost}");
            Console.WriteLine($"НДС {ndsTeaLipton}%");
            Console.WriteLine($"Итого {teaLiptonCost + milkCost}");
            Console.WriteLine($"НДС {ndsMilk}% \t {ndsMilk * milkCost / 100}");
            Console.WriteLine($"НДС {ndsTeaLipton}% \t {ndsTeaLipton * teaLiptonCost / 100}");
            // Список товаров
            // Расчет
            float Cost = 500;
            Console.WriteLine(new string('*', origWidth));
            Console.WriteLine($"Наличными {Cost}");
            Console.WriteLine($"Сдача {Cost - (milkCost + teaLiptonCost)}");
            Console.WriteLine(new string('*', origWidth));
            
            // Расчет
            // Футер чека

            string taxSys = "ОСНО";
            string taxSysText = $"Система налогооблажения {taxSys}";
            int fiscalCheck = 123456;
            string fiscaChekText = $"Фиск. чек № {fiscalCheck}";
            int kkt = 479949;
            string kktText = $"Код ККТ {kkt}";
            int fn = 99990;
            string fnText = $"ФН {fn}";
            string odf = "Первый ОФД";
            string odfText = $"ОФД {odf}";
            int padding;

            padding = origWidth / 2 + taxSysText.Length / 2;                //этот вариант записи выравнивания лучше
            Console.WriteLine("{0," + padding + "}", taxSysText);           //этот вариант записи выравнивания лучше
            padding = origWidth / 2 + fiscaChekText.Length / 2;
            Console.WriteLine("{0," + padding + "}", fiscaChekText);
            padding = origWidth / 2 + kktText.Length / 2;
            Console.WriteLine("{0," + padding + "}", kktText);
            padding = origWidth / 2 + fnText.Length / 2;
            Console.WriteLine("{0," + padding + "}", fnText);
            padding = origWidth / 2 + odfText.Length / 2;
            Console.WriteLine("{0," + padding + "}", odfText);

            // Сюда напрашивается QR код ... QR_ZXing - библиотека для генерации
            //      !               !       //
            //      !   ДОПИЛИТЬ    !       //
            //      !               !       //
            // Футер чека
            Console.ReadLine();
        }
    }
}
