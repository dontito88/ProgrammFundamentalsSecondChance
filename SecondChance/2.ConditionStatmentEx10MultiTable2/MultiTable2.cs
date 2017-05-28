namespace _2.ConditionStatmentEx10MultiTable2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiTable2
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var startFrom = int.Parse(Console.ReadLine());

            if (startFrom > 10)
            {
                Console.WriteLine($"{n} X {startFrom} = {n * startFrom}");
            }
            else
            {
                for (int i = startFrom; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }
    }
}
