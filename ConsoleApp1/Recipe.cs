
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void Scaling(double Quantity)
        {

            // Ask the user if they want to scale the recipe
            Console.WriteLine("\nDo you want to scale the recipe?");
            Console.WriteLine("1. 0.5x");
            Console.WriteLine("2. 1x (no scaling)");
            Console.WriteLine("3. 2x");
            Console.WriteLine("4. 3x");
            Console.Write("Enter your choice: ");

            int scaleChoice = int.Parse(Console.ReadLine());


            double scaleFactor;

            switch (scaleChoice)
            {
                case 1:
                    scaleFactor = 0.5 * Quantity;

                    break;
                case 3:
                    scaleFactor = 2.0 * Quantity;
                    break;
                case 4:
                    scaleFactor = 3.0 * Quantity;
                    break;
                default:
                    break;
            }

        }

        }


    }


