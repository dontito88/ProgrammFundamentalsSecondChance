namespace chooseDrink2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class chooseDrink2
    {
        public static void Main()
        {
            var people = int.Parse(Console.ReadLine());
            var package = Console.ReadLine().ToLower().Trim();
            var totalPrice = 0;

            switch (package)
            {
                case "normal":
                    if (people <= 50)
                    {
                        totalPrice = 2850;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    else if (people > 50 && people <= 100)
                    {
                        totalPrice = 5225;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    else if (people > 100 && people <= 120)
                    {
                        totalPrice = 5225;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    break;

                case "gold":
                    if (people <= 50)
                    {
                        totalPrice = 2925;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    else if (people > 50 && people <= 100)
                    {
                        totalPrice = 5175;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    else if (people > 100 && people <= 120)
                    {
                        totalPrice = 7425;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    break;

                case "platinum":
                    if (people <= 50)
                    {
                        totalPrice = 2975;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    else if (people > 50 && people <= 100)
                    {
                        totalPrice = 5100;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    else if (people > 100 && people <= 120)
                    {
                        totalPrice = 7225;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {(totalPrice / people).ToString("0.00")}$");
                    }
                    break;

                default: Console.WriteLine("We do not have an appropriate hall.");
                    break;
            }
        }
    }
}