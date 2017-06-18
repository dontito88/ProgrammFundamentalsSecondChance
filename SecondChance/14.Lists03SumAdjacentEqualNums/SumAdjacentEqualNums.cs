using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lists03SumAdjacentEqualNums
{
    class SumAdjacentEqualNums
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {

                }
            }
        }
    }
}
