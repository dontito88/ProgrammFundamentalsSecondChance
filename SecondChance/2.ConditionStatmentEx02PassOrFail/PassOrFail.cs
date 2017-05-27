namespace _2.ConditionStatmentEx02PassOrFail
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PassOrFail
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
