using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    enum Day
    {
        Sunday,    // 0
        Monday,    // 1
        Tuesday,   // 2
        Wednesday, // 3
        Thursday,  // 4
        Friday,    // 5
        Saturday   // 6
    }
    public static class ImplementEnum
    {
        public static void Show()
        {
            Day today = Day.Wednesday;
            Console.WriteLine(today);

            // Casting and Conversions
            int code = (int)Day.Friday;
            Console.WriteLine(code);

            Day err = (Day)1;
            Console.WriteLine(err);


            //  Looping Through Enums
            foreach (Day error in Enum.GetValues(typeof(Day)))
            {
                Console.WriteLine(error);
            }
        }
    }
}
