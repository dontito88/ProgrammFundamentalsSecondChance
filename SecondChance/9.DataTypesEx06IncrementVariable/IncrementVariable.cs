namespace _9.DataTypesEx06IncrementVariable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncrementVariable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = n / 256;
            int remaining = n % 256;
            
            if (counter == 0)
            {
                Console.WriteLine(remaining);
            }
            else
            {
                Console.WriteLine(remaining);
                Console.WriteLine($"Overflowed {counter} times");
            }
        }
    }
}
