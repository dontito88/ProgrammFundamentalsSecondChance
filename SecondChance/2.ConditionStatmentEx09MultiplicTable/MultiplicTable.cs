namespace _2.ConditionStatmentEx09MultiplicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplicTable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
