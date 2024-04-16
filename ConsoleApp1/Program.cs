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
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.Write($"Step {i + 1}: ");
                string description = Console.ReadLine();

                recipe.AddStep(description);
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