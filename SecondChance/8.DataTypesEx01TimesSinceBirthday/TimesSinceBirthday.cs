namespace _8.DataTypesEx01TimesSinceBirthday
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TimesSinceBirthday
    {
        public static void Main()
        {
            ulong years = byte.Parse(Console.ReadLine());
            ulong days = years * 365;
            ulong hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}
