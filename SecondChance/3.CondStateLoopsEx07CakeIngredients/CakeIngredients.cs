namespace _3.CondStateLoopsEx07CakeIngredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CakeIngredients
    {
        public static void Main()
        {
            var ingredient = Console.ReadLine();
            var counter = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");

                counter++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
