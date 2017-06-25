using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ArrAndListAlgL01.ArrContainElement
{
    class ArrContainElement
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementToFind = int.Parse(Console.ReadLine());
            bool isContained = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elementToFind)
                {
                    isContained = true;
                }
            }

            if (isContained == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
