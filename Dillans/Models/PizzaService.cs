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
    }
}