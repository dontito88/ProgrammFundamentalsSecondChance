namespace _2.ConditionStatmentEx12NumberChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberChecker
    {
        public static void Main()
        {

            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch 
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
