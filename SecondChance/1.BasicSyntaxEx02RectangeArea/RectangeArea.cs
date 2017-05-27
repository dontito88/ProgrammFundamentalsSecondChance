namespace BasicSyntaxEx02RectangeArea
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectangeArea
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var area = a * b;

            Console.WriteLine(area.ToString("0.00"));
        }
    }
}
