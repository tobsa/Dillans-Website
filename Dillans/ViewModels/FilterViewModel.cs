using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dillans.Models;

namespace Dillans.ViewModels
{
    public class FilterViewModel : BaseViewModel
    {
        public List<string> FreeIngredients { get; set; }
        public List<string> UsedIngredients { get; set; }
    }
}