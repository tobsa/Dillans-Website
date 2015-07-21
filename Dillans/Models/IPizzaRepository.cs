using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public interface IPizzaRepository
    {
        List<PizzaGroup> GetPizzaGroups();
    }
}