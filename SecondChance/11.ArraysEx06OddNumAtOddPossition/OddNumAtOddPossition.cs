namespace _11.ArraysEx06OddNumAtOddPossition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddNumAtOddPossition
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if ((i % 2 != 0) && (inputArray[i] % 2 != 0))
                {
                    Console.WriteLine($"Index {i} -> {inputArray[i]}");
                }
            }
        }
    }
}
