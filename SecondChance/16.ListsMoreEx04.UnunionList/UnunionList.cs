using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ListsMoreEx04.UnunionList
{
    class UnunionList
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < currentList.Count; j++)
                {
                    if (inputList.Contains(currentList[j]))
                    {
                        inputList.RemoveAll(item => item == currentList[j]);
                    }
                    else if (!inputList.Contains(currentList[j]))
                    {
                        inputList.Add(currentList[j]);
                    }
                }
            }

            inputList.Sort();
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
