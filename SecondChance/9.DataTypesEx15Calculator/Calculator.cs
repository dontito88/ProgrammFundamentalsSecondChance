namespace _9.DataTypesEx15Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        public static void Main()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int secondOperand = int.Parse(Console.ReadLine());

            switch (sign)
            {
                case "+": Console.WriteLine($"{firstOperand} {sign} {secondOperand} = {firstOperand + secondOperand}");
                    break;
                case "-":
                    Console.WriteLine($"{firstOperand} {sign} {secondOperand} = {firstOperand - secondOperand}");
                    break;
                case "*":
                    Console.WriteLine($"{firstOperand} {sign} {secondOperand} = {firstOperand * secondOperand}");
                    break;
                case "/":
                    Console.WriteLine($"{firstOperand} {sign} {secondOperand} = {firstOperand / secondOperand}");
                    break;
            }
        }
    }
}
