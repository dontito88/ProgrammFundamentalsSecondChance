using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx03RepeatedString
{
    class RepeatedString
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(inputString, repetitions));
        }

        static string RepeatString(string input, int repetitions)
        {
            string finalString = string.Empty;
            for (int i = 0; i < repetitions; i++)
            {
                finalString += input;
            }
            return finalString;
        }
    }
}
