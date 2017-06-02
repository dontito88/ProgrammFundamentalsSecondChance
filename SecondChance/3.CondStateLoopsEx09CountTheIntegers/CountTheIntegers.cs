namespace _3.CondStateLoopsEx09CountTheIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountTheIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var number = 0;
            var counter = 0;
            
            do
            {
                bool isInteger = int.TryParse(input, out number);

                if (isInteger == true)
                {
                    counter++;
                }
                else
                {
                    break;
                }

                input = Console.ReadLine();

            } while (true);

            Console.WriteLine(counter);
        }
    }
}
