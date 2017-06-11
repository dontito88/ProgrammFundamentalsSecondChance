namespace _9.DataTypesEx07TerabytesToBits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class TrickyString
    {
        public static void Main()
        {
            string symbol = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());
            List<string> result= new List<string>();
            for (int i = 1; i <= repetitions; i++)
            {
                string input = Console.ReadLine();
                result.Add(input);
            }
            Console.WriteLine(string.Join(symbol, result));
        }
    }
}
