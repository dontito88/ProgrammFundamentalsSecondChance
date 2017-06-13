namespace _12ArraysEx01HelloName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);

        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
