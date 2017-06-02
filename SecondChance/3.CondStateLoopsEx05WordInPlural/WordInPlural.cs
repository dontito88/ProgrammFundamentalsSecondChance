namespace _3.CondStateLoopsEx05WordInPlural
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WordInPlural
    {
        public static void Main()
        {
            var word = Console.ReadLine().Trim();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||
                     word.EndsWith("ch") ||
                     word.EndsWith("s") ||
                     word.EndsWith("sh") ||
                     word.EndsWith("x") ||
                     word.EndsWith("z"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }

            Console.WriteLine(word);
        }
    }
}
