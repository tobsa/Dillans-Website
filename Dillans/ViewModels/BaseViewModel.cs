using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Dillans.Models;

namespace Dillans.ViewModels
{
    public class BaseViewModel
    {
        public List<PizzaGroup> PizzaGroups { get; set; }

        public string GetIngredientName(Pizza pizza, int index)
        {
            var name = pizza.Ingredients[index].Description().ToLower();
            return index == pizza.Ingredients.Count - 1 ? name : name + ", ";
        }

        public string GetTypeName(Pizza pizza)
        {
            switch (pizza.Types.Count)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return "(" + pizza.Types.First().Description().ToLower() + ")";
            }

            var builder = new StringBuilder();

            builder.Append("(");
            foreach (var type in pizza.Types)
                builder.Append(type.Description().ToLower() + ", ");

            builder.Remove(builder.Length - 2, 2);
            builder.Append(")");

            return builder.ToString();
        }

        public int ClearFix { get; set; }
    }
}