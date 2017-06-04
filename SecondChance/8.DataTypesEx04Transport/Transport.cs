namespace _8.DataTypesEx04Transport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Transport
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());

            int capacity = 24;

            int courses = (int)Math.Ceiling((double)persons / capacity);

            Console.WriteLine(courses);
        }
    }
}
