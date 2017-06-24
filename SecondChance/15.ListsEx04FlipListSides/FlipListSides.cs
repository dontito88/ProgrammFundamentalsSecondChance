using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ListsEx04FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var leftSide = new List<int>();
            var rightSide = new List<int>();

            for (int i = 1; i < (inputList.Count) / 2; i++)
            {
                leftSide.Add(inputList[i]);
            }

            for (int i = ((inputList.Count) / 2) + 1; i < inputList.Count - 1; i++)
            {
                rightSide.Add(inputList[i]);
            }

            leftSide.Reverse();
            rightSide.Reverse();

            Console.WriteLine(inputList[0] + " " + string.Join(" ", rightSide) + " " + inputList[(inputList.Count) / 2] + " " +
                string.Join(" ", leftSide) + " " + inputList[inputList.Count - 1]);
        }
    }
}
