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
                },

                new PizzaGroup()
                {
                    Name = "Prisklass 3",
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza(16, "Quattro Stagioni", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Räkor, Ingredient.Musslor, Ingredient.Champinjoner, Ingredient.Oliver, Ingredient.Kronärtskocka }),
                        new Pizza(17, "Mexicana", new List<Ingredient>() { Ingredient.Köttfärs, Ingredient.Lök, Ingredient.Paprika }),
                        new Pizza(18, "Calzone Special", new List<Ingredient>() { Ingredient.Gorgonzola, Ingredient.Köttfärssås }),
                        new Pizza(19, "Daniels Special", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Räkor, Ingredient.Köttfärssås }),
                        new Pizza(20, "Opera", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Räkor, Ingredient.Tonfisk }),
                        new Pizza(21, "Prinsessa", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Räkor, Ingredient.Ananas }),
                        new Pizza(22, "Pigalle", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Räkor, Ingredient.Feferoni }),
                        new Pizza(23, "Mesopotamia", new List<Ingredient>() { Ingredient.Lök, Ingredient.Köttfärs, Ingredient.Salami }),
                        new Pizza(24, "Disco", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Räkor, Ingredient.Köttfärssås }),
                        new Pizza(25, "Jamaica", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Champinjoner, Ingredient.Räkor }),
                        new Pizza(26, "Maffioso", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Skinka, Ingredient.Gorgonzola }),
                        new Pizza(27, "Amigo", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Lök, Ingredient.Paprika, Ingredient.Köttfärssås }),
                        new Pizza(28, "Vakern", new List<Ingredient>() { Ingredient.Kyckling, Ingredient.Jordnötter }),
                        new Pizza(29, "Mamma Mia", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Räkor, Ingredient.Gorgonzola }),
                    }
                },

                new PizzaGroup()
                {
                    Name = "Prisklass 4",
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza(30, "Pizza Mexi", new List<Ingredient>() { Ingredient.Köttfärs, Ingredient.Tacokryddmix, Ingredient.Vitlök, Ingredient.Lök, Ingredient.Tacosås, Ingredient.GreenChili }),
                        new Pizza(31, "Pizza Azteka", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Tacokryddmix, Ingredient.Tacosås, Ingredient.Jalapeno, Ingredient.Vitlökssås}),
                        new Pizza(32, "Ciao-Ciao", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Oxfile, Ingredient.Lök, Ingredient.Vitlökssås}),
                        new Pizza(33, "Jonte", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Ananas, Ingredient.Kebabkött, Ingredient.Bacon }),
                        new Pizza(34, "San Marco", new List<Ingredient>() { Ingredient.Lök, Ingredient.Paprika, Ingredient.Bacon, Ingredient.Champinjoner, Ingredient.Köttfärssås }),
                        new Pizza(35, "Regina", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Oxfile, Ingredient.Bearnaisesås}),
                        new Pizza(36, "Larnaca", new List<Ingredient>() { Ingredient.Bacon, Ingredient.Salami, Ingredient.Räkor, Ingredient.Lök, Ingredient.Champinjoner, Ingredient.Paprika }),
                        new Pizza(37, "Bella Napoli", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Paprika, Ingredient.Oxfile, Ingredient.Bearnaisesås }),
                        new Pizza(38, "Kebab Pizza", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Kebabkött, Ingredient.ValfriSås }),
                        new Pizza(39, "Amore", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Champinjoner, Ingredient.Bacon, Ingredient.Lök, Ingredient.Ägg }),
                        new Pizza(40, "Herrljunga Special", new List<Ingredient>() { Ingredient.Oxfile, Ingredient.Gorgonzola, Ingredient.Lök }),

                    }
                },

                new PizzaGroup()
                {
                    Name = "Prisklass 5",
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza(41, "Lena", new List<Ingredient>() { Ingredient.Lök, Ingredient.Paprika, Ingredient.Oxfile, Ingredient.Räkor, Ingredient.Bearnaisesås }),
                        new Pizza(42, "Reale", new List<Ingredient>() { Ingredient.FärskTomat, Ingredient.Lök, Ingredient.Paprika, Ingredient.Oxfile, Ingredient.Bearnaisesås }),
                        new Pizza(43, "Babylon", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Kebabkött, Ingredient.Vitlökssås }),
                        new Pizza(44, "Båten", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Skinka, Ingredient.Räkor, Ingredient.Paprika, Ingredient.Bearnaisesås }),
                        new Pizza(45, "57:an Special", new List<Ingredient>() { Ingredient.Lök, Ingredient.Paprika, Ingredient.Champinjoner, Ingredient.Oxfile, Ingredient.Vitlökssås }),
                        new Pizza(46, "Gourme", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Paprika, Ingredient.Oxfile, Ingredient.Bearnaisesås }),
                        new Pizza(47, "Favoriten", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Lök, Ingredient.Kebabkött, Ingredient.Kebabsås}),
                        new Pizza(48, "Husets Special", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Lök, Ingredient.Champinjoner, Ingredient.Oxfile, Ingredient.Bearnaisesås }),
                        new Pizza(49, "Tefat", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Champinjoner, Ingredient.Räkor, Ingredient.Salami, Ingredient.Lök }),
                        new Pizza(50, "Dillans", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Lök, Ingredient.Feferoni, Ingredient.Kebabkött, Ingredient.Isbergssallad, Ingredient.FärskTomat, Ingredient.ValfriSås }),
                        new Pizza(51, "Vikingbåt", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Feferoni, Ingredient.Kebabkött, Ingredient.Bearnaisesås, Ingredient.Lök }),
                        new Pizza(52, "Tropical Special", new List<Ingredient>() { Ingredient.Banan, Ingredient.MangoChutney, Ingredient.Kräftstjärtar, Ingredient.Curry, Ingredient.Vitlökssås }),
                        new Pizza(53, "Kär & Galen", new List<Ingredient>() { Ingredient.Lök, Ingredient.Räkor, Ingredient.Köttfärs, Ingredient.Kräftstjärtar, Ingredient.Bearnaisesås }),
                        new Pizza(54, "Bombey", new List<Ingredient>() { Ingredient.Jordnötter, Ingredient.Fläskfile, Ingredient.Banan, Ingredient.MangoChutney, Ingredient.Curry, Ingredient.StarkSås }),
                        new Pizza(55, "La Banana", new List<Ingredient>() { Ingredient.Fläskfile, Ingredient.Ananas, Ingredient.Banan, Ingredient.Curry, Ingredient.ValfriSås }),
                        new Pizza(56, "Bagarens Special", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Kebabkött, Ingredient.Kebabsås, Ingredient.PommesFrites }),
                        new Pizza(57, "Messina", new List<Ingredient>() { Ingredient.Kebabkött, Ingredient.Ananas, Ingredient.StarkSås }),
                        new Pizza(58, "Ravelli", new List<Ingredient>() { Ingredient.Ost, Ingredient.Kebabkött, Ingredient.Lök, Ingredient.Isbergssallad, Ingredient.Tomat, Ingredient.Gurka, Ingredient.Feferoni, Ingredient.Kebabsås }),
                        new Pizza(59, "Malta", new List<Ingredient>() { Ingredient.Fläskfile, Ingredient.Lök, Ingredient.Vitlök, Ingredient.Tacosås, Ingredient.Kebabsås}),
                        new Pizza(60, "Alpina", new List<Ingredient>() { Ingredient.Fläskfile, Ingredient.Champinjoner, Ingredient.Lök, Ingredient.Bearnaisesås }),
                        new Pizza(61, "Herkules", new List<Ingredient>() { Ingredient.Fläskfile, Ingredient.Lök, Ingredient.Skinka, Ingredient.Bearnaisesås }),
                        new Pizza(62, "Rimini", new List<Ingredient>() { Ingredient.Kyckling, Ingredient.Kräftstjärtar, Ingredient.Ananas, Ingredient.Banan, Ingredient.Curry, Ingredient.Jordnötter, Ingredient.Kebabsås }),
                        new Pizza(63, "Petto", new List<Ingredient>() { Ingredient.Kyckling, Ingredient.Skinka, Ingredient.Lök, Ingredient.Tomat, Ingredient.Gurka, Ingredient.Isbergssallad, Ingredient.Feferoni, Ingredient.Kebabsås }),
                        new Pizza(64, "Florens", new List<Ingredient>() { Ingredient.Kyckling, Ingredient.Skinka, Ingredient.Lök, Ingredient.Tomat, Ingredient.Gurka, Ingredient.Isbergssallad, Ingredient.Feferoni, Ingredient.Kebabsås}),
                        new Pizza(65, "Häng Över", new List<Ingredient>() { Ingredient.Lök, Ingredient.Kebabkött, Ingredient.Kyckling, Ingredient.Jordnötter, Ingredient.Kräftstjärtar, Ingredient.FärskVitlök, Ingredient.Kebabsås }),
                        new Pizza(66, "El Peligro", new List<Ingredient>() { Ingredient.Kebabkött, Ingredient.Köttfärssås, Ingredient.Champinjoner, Ingredient.Banan, Ingredient.Curry, Ingredient.Vitlökssås}),
                        new Pizza(67, "Kyckling Special", new List<Ingredient>() { Ingredient.Kyckling, Ingredient.Skinka, Ingredient.Paprika, Ingredient.Ananas, Ingredient.Banan, Ingredient.Nötter, Ingredient.Curry, Ingredient.Kebabsås }),
                        new Pizza(68, "Lotta Special", new List<Ingredient>() { Ingredient.Kyckling, Ingredient.Räkor, Ingredient.Lök, Ingredient.FärskVitlök, Ingredient.Curry, Ingredient.Champinjoner, Ingredient.Kräftstjärtar, Ingredient.Kebabsås }),
                        new Pizza(69, "Pizza Acapulco", new List<Ingredient>() { Ingredient.Oxfile, Ingredient.Tacokryddmix, Ingredient.Vitlök, Ingredient.Lök, Ingredient.Jalapeno, Ingredient.Champinjoner, Ingredient.Tacosås }),
                        new Pizza(70, "Sofia Special", new List<Ingredient>() { Ingredient.FärskVitlök, Ingredient.Bacon, Ingredient.Oxfile, Ingredient.Köttfärssås, Ingredient.Lök}),
                        new Pizza(71, "Havets Special", new List<Ingredient>() { Ingredient.Tonfisk, Ingredient.Räkor, Ingredient.Musslor, Ingredient.Kräftor, Ingredient.ValfriSås}),
                        new Pizza(72, "Nina Special", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Skinka, Ingredient.Fetaost, Ingredient.Oliver, Ingredient.Oxfile, Ingredient.Bearnaisesås}),
                        new Pizza(73, "Quattro Formaggi (4 olika ostar)", new List<Ingredient>() { Ingredient.Mozzarella, Ingredient.Gorgonzola, Ingredient.Fetaost, Ingredient.Oxfile, Ingredient.FärskTomat }),
                        new Pizza(74, "BMW Special", new List<Ingredient>() { Ingredient.Kebabkött, Ingredient.RåLök, Ingredient.Bearnaisesås, Ingredient.Kebabsås }),
                        new Pizza(75, "Sköterskan", new List<Ingredient>() { Ingredient.Champinjoner, Ingredient.Paprika, Ingredient.Lök, Ingredient.Fläskfile, Ingredient.Banan, Ingredient.Curry  }),
                        new Pizza(76, "Medelhavet", new List<Ingredient>() { Ingredient.BlåMusslor, Ingredient.Scampi, Ingredient.Sparris, Ingredient.Vitlök }),
                        new Pizza(77, "H.S.K", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Champinjoner, Ingredient.Räkor, Ingredient.Fläskfile, Ingredient.Bearnaisesås }),
                        new Pizza(78, "UFO", new List<Ingredient>() { Ingredient.Lök, Ingredient.Paprika, Ingredient.Champinjoner, Ingredient.Vitlök, Ingredient.Fläskfile }),
                        new Pizza(79, "Black & White", new List<Ingredient>() { Ingredient.Skinka, Ingredient.Champinjoner, Ingredient.Oxfile, Ingredient.Fläskfile, Ingredient.Bearnaisesås }),
                        new Pizza(80, "Gabriel", new List<Ingredient>() { Ingredient.Fläskfile, Ingredient.Banan, Ingredient.Ananas, Ingredient.Jordnötter, Ingredient.Curry }),
                    }
                },

                new PizzaGroup()
                    {
                        Name = "Mozarella",
                        Pizzas = new List<Pizza>()
                        {
                            new Pizza("Le Chef", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.SoltorkadeTomater, Ingredient.Parmaskinka, Ingredient.Ruccolasallad }),
                            new Pizza("Musti", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Vitlök, Ingredient.SoltorkadeTomater, Ingredient.Parmaskinka, Ingredient.Mortadella, Ingredient.Pepparsalami }),
                            new Pizza("Vatikan", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Champinjoner, Ingredient.Oxfile, Ingredient.FärskTomat, Ingredient.Bearnaisesås }),
                            new Pizza("Bogart", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Champinjoner, Ingredient.Fläskfile, Ingredient.Lök, Ingredient.FärskTomat, Ingredient.Bearnaisesås }),
                            new Pizza("Chisto", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Lök, Ingredient.Feferoni, Ingredient.Cayennepeppar, Ingredient.Pepparsalami}),
                            new Pizza("Izo", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.SoltorkadeTomater, Ingredient.Parmaskinka, Ingredient.Pesto, Ingredient.Ruccolasallad }),
                            new Pizza("Parma", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Champinjoner, Ingredient.Oliver, Ingredient.Parmaskinka, Ingredient.Ruccolasallad }),
                            new Pizza("Ruccola", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.FärskTomat, Ingredient.Ruccolasallad, Ingredient.Olivolja, Ingredient.Champinjoner, Ingredient.Oliver }),
                            new Pizza("Fanny", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Paprika, Ingredient.Champinjoner, Ingredient.Parmaskinka, Ingredient.Mortadella }),
                            new Pizza("Sinatra", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Champinjoner, Ingredient.Paprika, Ingredient.Lök, Ingredient.Fläskfile, Ingredient.Bearnaisesås }),
                            new Pizza("Italiens", new List<Ingredient>() { Ingredient.Tomat, Ingredient.Mozzarella, Ingredient.Skinka, Ingredient.Champinjoner, Ingredient.FärskTomat}),
                        }
                    }
            };
        }
    }
}