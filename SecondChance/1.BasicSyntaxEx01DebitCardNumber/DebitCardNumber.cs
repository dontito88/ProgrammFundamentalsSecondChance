namespace BasicSyntaxEx01DebitCardNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DebitCardNumber
    {
        public static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.Write($"{num1.ToString("0000")} {num2.ToString("0000")} {num3.ToString("0000")} {num4.ToString("0000")}");
        }
    }
}
