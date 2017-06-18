using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx14EqualSequence
{
    class EqualSequence
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int firstElement = input[0];
            int counter = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != firstElement)
                {
                    counter++;
                }
            }

            if (counter == 0)
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
