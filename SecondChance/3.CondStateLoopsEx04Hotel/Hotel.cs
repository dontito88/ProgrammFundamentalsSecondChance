namespace _3.CondStateLoopsEx04Hotel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine().ToLower().Trim();
            var nightCount = int.Parse(Console.ReadLine());

            var studioPrice = 0;
            var doublePrice = 0;
            var suitPrice = 0;
            var discount = 0;

            switch(month)
            {
                case "may":
                case "october":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitPrice = 75;
                    break;

                case "june":
                case "september":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitPrice = 82;
                    break;

                case "july":
                case "august":
                case "december":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitPrice = 89;
                    break;
            }
        }
    }
}
