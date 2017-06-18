using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ArraysEx15CountCapitalLetters
{
    class CountCapitalLetters
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "A" || input[i] == "B" || input[i] == "C" || input[i] == "D" || input[i] == "E" || 
                    input[i] == "F" || input[i] == "G" || input[i] == "H" || input[i] == "I" || input[i] == "G" ||
                    input[i] == "K" || input[i] == "L" || input[i] == "M" || input[i] == "N" || input[i] == "O" ||
                    input[i] == "P" || input[i] == "Q" || input[i] == "R" || input[i] == "S" || input[i] == "T" ||
                    input[i] == "U" || input[i] == "V" || input[i] == "W" || input[i] == "X" || input[i] == "Y" ||
                    input[i] == "Z")
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
