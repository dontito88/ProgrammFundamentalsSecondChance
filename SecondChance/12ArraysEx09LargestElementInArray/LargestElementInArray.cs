using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx09LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > maxNumber)
                {
                    maxNumber = input;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
