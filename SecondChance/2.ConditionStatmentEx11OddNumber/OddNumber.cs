namespace _2.ConditionStatmentEx11OddNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddNumber
    {
        public static void Main()
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));

            while (n % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                n = Math.Abs(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"The number is: {n}");
        }
    }
}
