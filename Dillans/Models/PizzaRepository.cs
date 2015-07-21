using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public class PizzaRepository : IPizzaRepository
    {
        public List<PizzaGroup> GetPizzaGroups()
        {
            return new List<PizzaGroup>()
            {
                new PizzaGroup()
                {
                    Name = "Prisklass 1",
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza(1, "Margherita", new List<Ingredient>()),
                        new Pizza(2, "Vesuvio", new List<Ingredient>() { Ingredient.Skinka }),
                        new Pizza(3, "Calzone", new List<Ingredient>() { Ingredient.Skinka }),
                        new Pizza(4, "Kasalinka", new List<Ingredient>() { Ingredient.Champinjoner }),
                        new Pizza(5, "Bari", new List<Ingredient>(){ Ingredient.Salami }),
                        new Pizza(6, "Al tono", new List<Ingredient>() { Ingredient.Tonfisk })
                    }
                },

                new PizzaGroup()
                {
                    Name = "Prisklass 2",
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza(7, "Tomasso", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Räkor }),
                        new Pizza(8, "Capricciosa", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Champinjoner }),
                        new Pizza(9, "Primavera", new List<Ingredient>() { Ingredient.Bacon, Ingredient.Lök }),
                        new Pizza(10, "Orientale", new List<Ingredient>(){ Ingredient.Köttfärssås }),
                        new Pizza(11, "Hawaii", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Ananas }),
                        new Pizza(12, "Dilbahar", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Köttfärssås }),
                        new Pizza(13, "Marinara", new List<Ingredient>() { Ingredient.Räkor, Ingredient.Musslor }),
                        new Pizza(14, "Vegetariana", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Paprika, Ingredient.Oliver, Ingredient.Lök, Ingredient.Vitlök, Ingredient.Kronärtskocka }),
                        new Pizza(15, "Afrikana", new List<Ingredient>() { Ingredient.Ananas, Ingredient.Banan, Ingredient.Curry }),
                    }
                }
            };
        }
    }
}