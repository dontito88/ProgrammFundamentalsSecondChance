using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx12CountLargerNums
{
    class CountLargerNums
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double elementForCount = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > elementForCount)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
