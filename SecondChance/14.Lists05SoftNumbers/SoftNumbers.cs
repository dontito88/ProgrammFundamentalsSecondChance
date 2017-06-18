using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lists05SoftNumbers
{
    class SoftNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            inputList.Sort();

            Console.WriteLine(string.Join(" <= ", inputList));
        }
    }
}
