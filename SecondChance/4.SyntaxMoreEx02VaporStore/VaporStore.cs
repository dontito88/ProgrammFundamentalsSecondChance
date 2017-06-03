namespace _4.SyntaxMoreEx02VaporStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VaporStore
    {
        public static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().Trim();
            double gamePrice = 0;
            double spentForGames = 0;

            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4": gamePrice = 39.99;
                        spentForGames += gamePrice;
                        break;
                    case "CS: OG": gamePrice = 15.99;
                        spentForGames += gamePrice;
                        break;
                    case "Zplinter Zell": gamePrice = 19.99;
                        spentForGames += gamePrice;
                        break;
                    case "Honored 2": gamePrice = 59.99;
                        spentForGames += gamePrice;
                        break;
                    case "RoverWatch": gamePrice = 29.99;
                        spentForGames += gamePrice;
                        break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99;
                        spentForGames += gamePrice;
                        break;

                    default: Console.WriteLine("Not Found");
                        break;
                }

                if (gamePrice > money)
                {
                    Console.WriteLine("Too Expensive");
                    break;
                }
                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Bought {input}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${(spentForGames).ToString("0.00")}. Remaining: ${(money - spentForGames).ToString("0.00")}");
        }
    }
}
