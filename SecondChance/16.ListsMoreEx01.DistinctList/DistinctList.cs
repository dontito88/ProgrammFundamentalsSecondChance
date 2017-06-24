using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ListsMoreEx01.DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = inputList.Distinct().ToList();

            foreach (var item in resultList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
