namespace _4SyntaxMoreEx01X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class X
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var innerWhiteSpace = (n / 2) + 2;
            var outerWhiteSpace = 1;

            if (n % 2 == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine("X" + new string(' ', n - 2) + "X");

                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine(new string(' ', outerWhiteSpace) + "X" + new string(' ', innerWhiteSpace) + "X" + new string(' ', outerWhiteSpace));
                    outerWhiteSpace++;
                    innerWhiteSpace -= 2;
                }
                Console.WriteLine();
            }
        }
    }
}
