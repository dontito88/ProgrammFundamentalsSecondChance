namespace _11.ArraysEx02MultiplyDoubleArraysEl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplyDoubleArraysEl
    {
        public static void Main()
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double multiplyNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multiplyNum;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
