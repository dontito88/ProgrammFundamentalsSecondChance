namespace _3.CondStateLoopsEx08CaloriesCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CaloriesCounter
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToLower().Trim();

                switch (input)
                {
                    case "cheese": totalCalories += 500;
                        break;
                    case "tomato sauce": totalCalories += 150;
                        break;
                    case "salami": totalCalories += 600;
                        break;
                    case "pepper": totalCalories += 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
