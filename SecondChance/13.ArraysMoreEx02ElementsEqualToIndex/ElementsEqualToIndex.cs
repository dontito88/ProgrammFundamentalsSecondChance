﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ArraysMoreEx02ElementsEqualToIndex
{
    class ElementsEqualToIndex
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == i)
                {
                    Console.Write(input[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
