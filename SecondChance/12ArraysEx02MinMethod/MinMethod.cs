namespace _12ArraysEx02MinMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(a, b, c));
        }
        static int GetMin(int a, int b, int c)
        {
            int minNumber = Math.Min(a, b);
            int finalMinNumber = Math.Min(minNumber, c);
            return finalMinNumber;
        }
    }
}
