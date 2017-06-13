using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx13IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int minValue = int.MinValue;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > minValue)
                {
                    minValue = input[i];
                }
            }

            if (minValue == input[input.Length - 1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
