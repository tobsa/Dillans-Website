using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Dillans.Models
{
    public enum Ingredient
    {
        Ananas,

	    Bacon,
	    Banan,
	    Bearnaisesås,

        [Description("Blå Musslor")]
	    BlåMusslor,

	    Cayennepeppar,
	    Champinjoner,
	    Curry,

	    Feferoni,
	    Fetaost,

        [Description("Fläskfilé")]
	    Fläskfile,

        [Description("Färsk Tomat")]
	    FärskTomat,

        [Description("Färsk Vitlök")]
	    FärskVitlök,

	    Gorgonzola,

        [Description("Green Chili")]
	    GreenChili,
	    Gurka,

	    Isbergssallad,

	    Jalapeno,
	    Jordnötter,

	    Kebabkött,
	    Kebabsås,
	    Kronärtskocka,
	    Kräftor,
	    Kräftstjärtar,
	    Kyckling,
	    Köttfärs,
	    Köttfärssås,

	    Lök,
	    
        [Description("Mango Chutney")]
	    MangoChutney,
	    Mortadella,
	    Mozzarella,
	    Musslor,

	    Nötter,

	    Oliver,
	    Olivolja,
	    Ost,

        [Description("Oxfilé")]
	    Oxfile,

	    Paprika,
	    Parmaskinka,
	    Pepparsalami,
	    Pesto,

        [Description("Pommes Frites")]
	    PommesFrites,

	    Ruccolasallad,

        [Description("Rå Lök")]
	    RåLök,
	    Räkor,

	    Salami,
	    Scampi,
	    Skinka,

        [Description("Soltorkade Tomater")]
	    SoltorkadeTomater,
	    Sparris,

        [Description("Stark Sås")]
	    StarkSås,

	    Tacokryddmix,
	    Tacosås,
	    Tomat,
	    Tonfisk,

        [Description("Valfri Sås")]
	    ValfriSås,
	    Vitlök,
	    Vitlökssås,

	    Ägg,
    }

    public static class AttributesHelperExtension
    {
        public static string Description(this Enum value)
        {
            var da = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return da.Length > 0 ? da[0].Description : value.ToString();
        }
    }
}