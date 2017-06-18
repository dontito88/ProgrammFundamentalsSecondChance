using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lists01RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            inputList.Reverse();

            List<int> possitiveList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > 0)
                {
                    possitiveList.Add(inputList[i]);
                }
            }

            if (possitiveList.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var item in possitiveList)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
