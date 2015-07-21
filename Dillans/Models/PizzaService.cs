using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public class PizzaService
    {
        private readonly IPizzaRepository _repository = new PizzaRepository();

        public List<PizzaGroup> GetPizzaGroups()
        {
            return _repository.GetPizzaGroups();
        }

        public List<string> GetIngredients()
        {
            return EnumUtil.GetValues<Ingredient>().Select(x => x.Description()).ToList();
        }

        public List<string> GetFreeIngredients()
        {
            return GetIngredients().Where(x => GetUsedIngredients().All(y => x != y)).ToList();
        }

        public List<string> GetUsedIngredients()
        {
            return HttpContext.Current.Session["UsedIngredients"] as List<string> ?? new List<string>();
        }

        public void AddUsedIngredient(string ingredient)
        {
            var usedIngredients = GetUsedIngredients();
            
            if (!usedIngredients.Contains(ingredient))
                usedIngredients.Add(ingredient);

            HttpContext.Current.Session["UsedIngredients"] = usedIngredients;
        }

        public List<PizzaGroup> GetFilteredPizzaGroups()
        {
            var groups = GetPizzaGroups();

            foreach (var group in groups)
            {
                group.Pizzas = group.Pizzas.Where(p => !GetUsedIngredients().Except(p.Ingredients.Select(i => i.Description())).Any()).ToList();
            }

            return groups;
        }

        public void ResetSession()
        {
            HttpContext.Current.Session["UsedIngredients"] = null;
        }

        public void RemoveUsedIngredient(string ingredient)
        {
            var usedIngredients = GetUsedIngredients();

            usedIngredients.Remove(ingredient);

            HttpContext.Current.Session["UsedIngredients"] = usedIngredients;
        }
    }
}