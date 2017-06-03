namespace _4.SyntaxMoreEx05BMPcounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BMPcounter
    {
        public static void Main()
        {
            var bpm = int.Parse(Console.ReadLine());
            var beats = int.Parse(Console.ReadLine());
            var bars = beats / 4;
            var seconds = (beats / bpm) * 60;
            var minutes = 0;

            if (seconds >= 60)
            {
                minutes = seconds / 60;
                seconds = seconds % 60;
                Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
            }
            else
            {
                Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
            }
        }
    }
}
