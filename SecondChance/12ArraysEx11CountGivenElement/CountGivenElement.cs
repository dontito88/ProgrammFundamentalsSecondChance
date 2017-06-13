using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx11CountGivenElement
{
    class CountGivenElement
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int elementForCount = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == elementForCount)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
