using ST10198206_PROG221_PartOne;
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
            //Created a menu for the user to select an option 
            bool exitRequested = false;

            //Breaks program when user selects option 2
            while (!exitRequested)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Recipe");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("2. Exit");
                Console.ResetColor();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                //Case and switch used for creating menu
                switch (choice)
                {
                    case "1":
                        AddRecipe();
                        break;
                    case "2":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            }
        }

        //Add recipie option
        static void AddRecipe()
        {
            //Class Name Object Name = new Constructor
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter recipe details:");


            //Error Handling for inputting number for Ingredients
            Console.Write("Number of ingredients: ");
            int numIngredients;
            while (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                Console.ResetColor();
                Console.Write("Number of ingredients: ");
            }

            //Creates a loop for the amount of the ingredients inputted by the user
            for (int i = 0; i < numIngredients; i++)
            {
                
                Console.Write("Ingredient name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity of ingredients: ");
                double quantity;
                while (!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a positive number for quantity.");
                    Console.ResetColor();
                    Console.Write("Quantity of Ingredient: ");
                }
                
                Console.Write("Unit of measurement: ");
                string measurementunit = Console.ReadLine();


                recipe.AddIngredient(name, quantity, measurementunit);

                recipe.Scaling(quantity);
            }

            //Ask the user for the number of steps 
            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            // Loops the number of steps that the user has inputed
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Step {i + 1}: ");
                string description = Console.ReadLine();
               

                recipe.AddStep(description);
            }


            Console.WriteLine("\nRecipe added successfully!");
            Console.WriteLine("\nDisplaying recipe:");

            //Change the colours of the Displayed text
            Console.ForegroundColor = ConsoleColor.Green;
            recipe.DisplayRecipe();
            Console.ResetColor();
        }
    }
}


//C# How to use Classes and Objects. 2016. YouTube video, added by Renaissance Coders. [Online]. Available at: https://www.youtube.com/watch?v=O8lc8MPxw64&list=PL4CCSwmU04Mh-1jjEBgpttAnZSA0bfhop&index=9 
//C# How to use Structs. 2016. Youtube video, added by Renaissance Coders. [Online]. Available at: https://youtu.be/rX_0qrHd8RM?si=pj59t04bvQLeuo7X
//C# How to use Arrays and Lists. 2016. Youtube video, added by Renaissance Coders. [Online]. Available at:: https://youtu.be/cmdBpKEEPbY?si=eB5M4NP_NVL_c8sh