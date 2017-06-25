using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ArrAndListAlgL07.LargestNelements
{
    class LargestNelements
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            inputList.Sort();
            inputList.Reverse();

            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write(inputList[i] + " ");
            }
        }
    }
}
