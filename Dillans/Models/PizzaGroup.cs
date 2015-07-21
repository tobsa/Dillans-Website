using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public class PizzaGroup
    {
        public string Name { get; set; }
        public List<Pizza> Pizzas { get; set; } 
    }
}