using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ListsEx01.RemoveOddElements
{
    class RemoveOddElements
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> resultList = new List<string>();
            
            for (int i = 1; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    resultList.Add(input[i]);
                }
            }
            foreach (var item in resultList)
            {
                Console.Write(item);
            }
        }
    }
}
