namespace _2.ConditionStatmentEx07DevisibleBy3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DevisibleBy3
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
