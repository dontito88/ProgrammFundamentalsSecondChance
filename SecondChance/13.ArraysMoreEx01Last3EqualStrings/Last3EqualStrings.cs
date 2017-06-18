using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ArraysMoreEx01Last3EqualStrings
{
    class Last3EqualStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int counter = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == input[i - 1] && counter == 3)
                {
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine($"{input[i]}");
                    }
                }  
            }
        }
    }
}
