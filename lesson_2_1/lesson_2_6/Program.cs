using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_6
{
    class Program
    {
        [Flags]
        public enum Week
        {
            monday =    0b_0000001,
            tuesday =   0b_0000010,
            wednesday = 0b_0000100,
            thursday =  0b_0001000,
            friday =    0b_0010000,
            saturday =  0b_0100000,
            sunday =    0b_1000000
        }
        static void Main(string[] args)
        {
            //DateTime dateValue = DateTime.Today;
            //Console.WriteLine("Today " + dateValue.ToString("dddd"));             // хотел добавит ввывод текущего дня недели, не разобрался как изменить язык.
            //Console.WriteLine("Номер дня недели " + (int)dateValue.DayOfWeek);
            // Mask
            Week workDeys = Week.monday | Week.tuesday | Week.wednesday | Week.thursday | Week.friday;
            Week workDeysOfice_2 = Week.monday | Week.tuesday | Week.wednesday;
            Week weekend = Week.saturday | Week.sunday;
            // Mask
            //
            Week allDeysOfWeek = (Week)0b_1111111;

            Week office1_WorkDeys = allDeysOfWeek & workDeys;
            Week office2_WorkDeys = allDeysOfWeek & workDeysOfice_2;
            Week production_WorkDeys = allDeysOfWeek & weekend;
            //Console.WriteLine($"Дни недели: {allDeysOfWeek}");
            //bool office1 = workDeys == office1_WorkDeys;
            //bool office2 = workDeysOfice_2 == office2_WorkDeys;
            //bool production = weekend == production_WorkDeys;
            Console.WriteLine($"Office 1 working days: {office1_WorkDeys}");
            Console.WriteLine($"Office 2 working days: {office2_WorkDeys}");
            Console.WriteLine($"Production working days: {production_WorkDeys}");
            Console.ReadLine();
        }
    }
}
