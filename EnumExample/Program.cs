using System;

namespace EnumExample
{
    class Program
    {
        enum DaysOfWeek
        {
            Sun, Mon, Tues, Wed, Thurs, Fri, Sat
        }

        enum DaysOfWeekTwo
        {
            Sun = 5, Mon = 10, Tues, Wed, Thurs, Fri, Sat
        }

        enum DaysOfWeekThree : byte
        {
            Sun,  Mon,Tues, Wed, Thurs, Fri, Sat
        }


        static void Main(string[] args)
        {
            DaysOfWeek myDays = DaysOfWeek.Mon;
            Console.WriteLine(myDays);
            Console.WriteLine((int)(myDays));
            Console.WriteLine((DaysOfWeek)1);

            DaysOfWeekTwo myDays2 = DaysOfWeekTwo.Tues;
            Console.WriteLine(myDays2);
            Console.WriteLine((int)(myDays2));
            Console.WriteLine((DaysOfWeekTwo)2);
            Console.ReadKey();
        }
    }
}
