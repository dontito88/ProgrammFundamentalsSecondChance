using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx04NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());
            int arrayCounter = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                arrayCounter++;
            }

            Console.WriteLine(inputNumber[arrayCounter - index]);
        }
    }
}
