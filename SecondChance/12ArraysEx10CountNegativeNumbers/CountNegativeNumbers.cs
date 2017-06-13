using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx10CountNegativeNumbers
{
    class CountNegativeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int negativeNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    negativeNumbers++;
                }
            }

            Console.WriteLine(negativeNumbers);
        }
    }
}
