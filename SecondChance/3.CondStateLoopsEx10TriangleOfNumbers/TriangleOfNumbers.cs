﻿namespace _3.CondStateLoopsEx10TriangleOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TriangleOfNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
