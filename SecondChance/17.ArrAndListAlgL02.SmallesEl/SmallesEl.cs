using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ArrAndListAlgL02.SmallesEl
{
    class SmallesEl
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int smallestElement = int.MaxValue;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] < smallestElement)
                {
                    smallestElement = inputList[i];
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
