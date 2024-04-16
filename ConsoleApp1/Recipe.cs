using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10198206_PROG221_PartOne
{
    internal class Recipe
    {
        //Added variables for ingredient
        public struct Ingredient
        {
            public string Name;
            public double Quantity;
            public string Unit;
        }

        //Lists to store the ingredients 
        public List<Ingredient> Ingredients;
       

        //constructor for the ingredients to initialize the lists
        public Recipe()
        {
            Ingredients = new List<Ingredient>(); 
        }

        //method for adding new ingredient
        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
        }

        //method for displaying the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            
        }


    }



}

          



//Classes and Objects: https://www.youtube.com/watch?v=O8lc8MPxw64&list=PL4CCSwmU04Mh-1jjEBgpttAnZSA0bfhop&index=9 
//Using Structs: https://youtu.be/rX_0qrHd8RM?si=pj59t04bvQLeuo7X
//Using Arrays and Lists: https://youtu.be/cmdBpKEEPbY?si=eB5M4NP_NVL_c8sh