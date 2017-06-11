namespace _11.ArraysEx01SumArrayElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] intArray = new int[n];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            Console.WriteLine(sum);
        }
    }
}
