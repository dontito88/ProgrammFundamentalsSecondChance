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
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 0.7).ToString("0.00")}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1).ToString("0.00")}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1).ToString("0.00")}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.7).ToString("0.00")}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.2).ToString("0.00")}.");
                    break;
            }
        }
    }
}