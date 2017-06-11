namespace _11.ArraysEx04RotateArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            string[] stringArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] changedArray = new string[stringArray.Length];

            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                changedArray[i + 1] = stringArray[i];
                string lastElement = stringArray[changedArray.Length - 1];
                changedArray[0] = lastElement;
            }
            Console.WriteLine(string.Join(" ", changedArray));
        }
    }
}
