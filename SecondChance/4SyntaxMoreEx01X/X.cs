namespace _4SyntaxMoreEx01X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class X
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col <= n ; col++)
                {
                    if (col == row)
                    {
                        Console.Write("x");
                    }
                    else if (col == n - 1 - row)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.WriteLine(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
