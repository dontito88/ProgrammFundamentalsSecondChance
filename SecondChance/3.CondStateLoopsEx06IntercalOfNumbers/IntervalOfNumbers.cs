namespace _3.CondStateLoopsEx06IntevcalOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntervalOfNumbers
    {
        public static void Main()
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var start = 0;
            var finish = 0;
            
            if (first > second)
            {
                start = second;
                finish = first;
            }
            else
            {
                start = first;
                finish = second;
            }

            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
