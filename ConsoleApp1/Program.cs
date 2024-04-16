using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10198206_PROG221_PartOne
{

    class Program
    {
        static void Main(string[] args)
        {
            //Class Name Object Name = new Constructor
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter recipe details:");
            
            //Ask the user for the number of ingredients
            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            
                Console.Write("Ingredient name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity of Ingredient: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(name, quantity, unit);



            Console.WriteLine("\nRecipe added successfully!");
            Console.WriteLine("\nDisplaying recipe:");
            recipe.DisplayRecipe();

          
        }
    }

}

