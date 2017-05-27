namespace _2.ConditionStatmentEx03BackIn30Min
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BackIn30Min
    {
        public static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var newMin = min + 30;

            if (newMin > 59)
            {
                hour++;

                if (hour > 23)
                {
                    hour = hour - 24;
                }
                min = newMin - min;
                Console.WriteLine($"{hour}:{(newMin - 60).ToString("00")}");
            }
            else
            {
                Console.WriteLine($"{hour}:{newMin}");
            }
        }
    }
}
