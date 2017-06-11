using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.DataTypesEx14ASCIIstring
{
    class ASCIIstring
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            List<char> result = new List<char>();
            char transformedNumber;
            for (int i = 1; i <= numberOfChars; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                transformedNumber = (char)inputNumber;
                result.Add(transformedNumber);
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
