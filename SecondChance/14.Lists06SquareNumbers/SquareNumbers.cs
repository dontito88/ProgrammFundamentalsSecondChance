using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lists06SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> squareNums = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (Math.Sqrt(inputList[i]) == (int)Math.Sqrt(inputList[i]))
                {
                    squareNums.Add(inputList[i]);
                }
            }

            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
