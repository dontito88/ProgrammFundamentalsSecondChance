using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ArrAndListAlgL03.ReversedArray
{
    class ReversedArray
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputList.Count / 2; i++)
            {
                int temp = inputList[i];
                inputList[i] = inputList[inputList.Count - 1 - i];
                inputList[inputList.Count - 1 - i] = temp;
            }

            Console.Write(string.Join(" ", inputList));
        }
    }
}
