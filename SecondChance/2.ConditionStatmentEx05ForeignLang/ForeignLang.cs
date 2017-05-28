namespace _2.ConditionStatmentEx05ForeignLang
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForeignLang
    {
        public static void Main()
        {
            var country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "usa":
                    Console.WriteLine("English");
                    break;

                case "england":
                    Console.WriteLine("English");
                    break;

                case "spain":
                    Console.WriteLine("Spanish");
                    break;

                case "argentina ":
                    Console.WriteLine("Spanish");
                    break;

                case "mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
