namespace _11.ArraysEx03SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int min = int.MaxValue;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                {
                    min = inputArray[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
