namespace _1.BasicSyntaxEx04BevarageLabels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BevarageLabels
    {
        public static void Main()
        {
            var food = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {food}:\n{(energy / 100) * volume}kcal, {(sugar / 100) * volume}g sugars");
        }
    }
}
