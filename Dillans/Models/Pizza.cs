using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public class Pizza
    {
        public static int InvalidNumber = -1;

        public Pizza(int number, string name, List<Ingredient> ingredients, List<Type> types)
        {
            Number = number;
            Name = name;
            Ingredients = ingredients;
            Types = types;
        }

        public Pizza(string name, List<Ingredient> ingredients) :
            this(InvalidNumber, name, ingredients, new List<Type>())
        {
        }

        public Pizza(int number, string name, List<Ingredient> ingredients) :
            this(number, name, ingredients, new List<Type>())
        {
        }

        public Pizza(string name, List<Ingredient> ingredients, List<Type> types) :
            this(InvalidNumber, name, ingredients, types)
        {
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Type> Types { get; set; } 
    }
}