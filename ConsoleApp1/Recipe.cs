
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10198206_PROG221_PartOne
{
    internal class Recipe
    {
        //variables for ingredient
        public struct Ingredient
        {
            public string Name;
            public double Quantity;
            public string MeasurementUnit;
        }

        //variables for the steps 
        public struct Step
        {
            public string Description;
        }

        //Lists to store the ingredients 
        public List<Ingredient> Ingredients;

        //Lists to store the ingredients 
        public List<Step> Steps;

        //constructor for the ingredients and steps to initialize the lists
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        //method for adding new ingredient
        public void AddIngredient(string name, double quantity, string measurementunit)
        {
            Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, MeasurementUnit = measurementunit });
        }

        //method for adding steps
        public void AddStep(string description)
        {
            Steps.Add(new Step { Description = description });
        }


        //method for displaying the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"The Quantity is: {ingredient.Quantity} and the Unit Measurement is: {ingredient.MeasurementUnit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }


        }


    }


}