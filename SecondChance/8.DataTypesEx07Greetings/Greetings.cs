namespace _8.DataTypesEx07Greetings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Greetings
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
