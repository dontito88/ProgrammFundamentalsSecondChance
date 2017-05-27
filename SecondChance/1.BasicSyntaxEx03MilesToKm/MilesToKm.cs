namespace _1.BasicSyntaxEx03MilesToKm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MilesToKm
    {
        public static void Main()
        {
            var kilometers = double.Parse(Console.ReadLine());
            var miles = kilometers * 1.60934;

            Console.WriteLine(miles.ToString("0.00"));
        }
    }
}
