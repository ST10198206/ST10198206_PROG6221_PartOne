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
                Console.WriteLine("2. Exit");
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

            //Ask the user for the number of ingredients
            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            //Creates a loop for the amount of the ingredients inputted by the user
            for (int i = 0; i < numIngredients; i++)
            {
                //Changes the colour of the text
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingredient name: ");
                string name = Console.ReadLine();
                Console.ResetColor();

                //Changes the colour of the text
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Quantity of Ingredient: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.ResetColor();

                //Changes the colour of the text
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Unit of measurement: ");
                string measurementunit = Console.ReadLine();
                Console.ResetColor();

                recipe.AddIngredient(name, quantity, measurementunit);
            }

            //Ask the user for the number of steps 
            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            // Loops the number of steps that the user has inputed
            for (int i = 0; i < numSteps; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Step {i + 1}: ");
                string description = Console.ReadLine();
                Console.ResetColor();

                recipe.AddStep(description);
            }

            // Ask the user if they want to scale the recipe
            Console.WriteLine("\nDo you want to scale the recipe?");
            Console.WriteLine("1. 0.5x");
            Console.WriteLine("2. 1x (no scaling)");
            Console.WriteLine("3. 2x");
            Console.WriteLine("4. 3x");
            Console.Write("Enter your choice: ");
            int scaleChoice = int.Parse(Console.ReadLine());

            double scaleFactor = 1.0;

            switch (scaleChoice)
            {
                case 1:
                    scaleFactor = 0.5 ;
                    break;
                case 3:
                    scaleFactor = 2.0;
                    break;
                case 4:
                    scaleFactor = 3.0;
                    break;
                default:
                    break;
            }

            

            Console.WriteLine("\nRecipe added successfully!");
            Console.WriteLine("\nDisplaying recipe:");

            //Change the colours of the Displayed text
            Console.ForegroundColor = ConsoleColor.Magenta;
            recipe.DisplayRecipe();
            Console.ResetColor();
        }
    }
}


//C# How to use Classes and Objects. 2016. YouTube video, added by Renaissance Coders. [Online]. Available at: https://www.youtube.com/watch?v=O8lc8MPxw64&list=PL4CCSwmU04Mh-1jjEBgpttAnZSA0bfhop&index=9 
//C# How to use Structs. 2016. Youtube video, added by Renaissance Coders. [Online]. Available at: https://youtu.be/rX_0qrHd8RM?si=pj59t04bvQLeuo7X
//C# How to use Arrays and Lists. 2016. Youtube video, added by Renaissance Coders. [Online]. Available at:: https://youtu.be/cmdBpKEEPbY?si=eB5M4NP_NVL_c8sh