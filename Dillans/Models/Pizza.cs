using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public class Pizza
    {
        public static int InvalidNumber = -1;

        public Pizza(int number, string name, List<Ingredient> ingredients)
        {
            Number = number;
            Name = name;
            Ingredients = ingredients;
        }

        public Pizza(string name, List<Ingredient> ingredients)
        {
            Number = InvalidNumber;
            Name = name;
            Ingredients = ingredients;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public string GetIngredientName(int index)
        {
            var name = Ingredients[index].Description().ToLower();
            return index == Ingredients.Count - 1 ? name : name + ", ";
        }
    }
}