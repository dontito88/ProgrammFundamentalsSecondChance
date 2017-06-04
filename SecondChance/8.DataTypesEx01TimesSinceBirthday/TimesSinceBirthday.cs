namespace _8.DataTypesEx01TimesSinceBirthday
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TimesSinceBirthday
    {
        public static void Main()
        {
            decimal years = decimal.Parse(Console.ReadLine());
            decimal days = years * 365;
            decimal hours = days * 24;
            decimal minutes = days * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}
