namespace _2.ConditionStatmentEx08SumOfOffNums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfOffNums
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (counter == n)
                {
                    break;
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter++;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
