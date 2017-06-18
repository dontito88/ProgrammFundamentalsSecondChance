using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lists02AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> resultList = new List<string>();

            inputList.Reverse();

            for (int i = 0; i < inputList.Count; i++)
            {
                string token = inputList[i].Trim();
                resultList.Add(token);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
