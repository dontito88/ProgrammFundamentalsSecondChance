namespace _8.DataTypesEx08RefracorPyramid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RefracorPyramid
    {
        public static void Main()
        {
            double lenght, width, height = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            var volume = (lenght + width + height);
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
