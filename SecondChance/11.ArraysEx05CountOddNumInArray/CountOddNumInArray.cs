namespace _11.ArraysEx05CountOddNumInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOddNumInArray
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int counter = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 != 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
