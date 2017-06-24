using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ListsMoreEx02.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                int indexToInsert = int.Parse(input[0].ToString());
                int numberToInsert = int.Parse(input);
                
                inputList.Insert(indexToInsert, numberToInsert);
                
                input = Console.ReadLine();
            }

            foreach (var item in inputList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
