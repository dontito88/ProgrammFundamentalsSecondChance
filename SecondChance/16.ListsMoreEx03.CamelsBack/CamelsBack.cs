using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ListsMoreEx03.CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            if (inputList.Count == n)
            {
                Console.WriteLine($"already stable: {string.Join(" ", inputList)}");
            }

            else
            {
                while (inputList.Count != n)
                {
                    inputList.RemoveAt(0);
                    inputList.RemoveAt(inputList.Count - 1);

                    counter++;
                }

                Console.WriteLine($"{counter} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", inputList)}");
            }
        }
    }
}
