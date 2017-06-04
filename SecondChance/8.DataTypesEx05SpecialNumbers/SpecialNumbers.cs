﻿namespace _8.DataTypesEx05SpecialNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;

                while (digits > 0 )
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool specialNumbers = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {specialNumbers}");
            }
        }
    }
}
