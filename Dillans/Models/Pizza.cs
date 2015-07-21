using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public class Pizza
    {
        public Pizza(int number, string name, List<Ingredient> ingredients)
        {
            Number = number;
            Name = name;
            Ingredients = ingredients;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; } 
    }
}