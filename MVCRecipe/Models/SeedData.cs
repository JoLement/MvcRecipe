using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCRecipe.Data;



namespace MVCRecipe.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCRecipeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCRecipeContext>>()))
            {
                // Look for any Recipes.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }


                    context.Recipe.AddRange(
                    new Recipe
                    {
                        Name = "Aubergines farcies végétariennes",
                        NumMeal = 4,
                        StartSeason = "Juin",
                        EndSeason = "Septembre",

                        Ingredient0 = "2 Aubergines",
                        Ingredient1 = "4 Tomates",
                        Ingredient2 = "2 Oignons",
                        Ingredient3 = "2 Gousses d'Ail",
                        Ingredient4 = "Herbes de Provence",
                        Ingredient5 = "Sel et Poivre",
                        Ingredient6 = "Huile d'Olive",
                        Ingredient7 = "",
                        Ingredient8 = "",
                        Ingredient9 = "",

                    },


                    new Recipe
                    {
                        Name = "Cake Chorizo Poivrons",
                        NumMeal = 4,
                        StartSeason = "Juin",
                        EndSeason = "Septembre",

                        Ingredient0 = "150g de Farine de Blé",
                        Ingredient1 = "80g de chorizo",
                        Ingredient2 = "3 Oeufs",
                        Ingredient3 = "100g de Gruyère",
                        Ingredient4 = "1 Poivron Rouge",
                        Ingredient5 = "1 Poivron Jaune",
                        Ingredient6 = "12,5 cl de Lait",
                        Ingredient7 = "Un Sachet de Levure Chimique",
                        Ingredient8 = "Sel et Poivre",
                        Ingredient9 = "Huile de Tournesol",

                    },


                    new Recipe
                    {
                        Name = "Crevettes au Topinambour",
                        NumMeal = 4,
                        StartSeason = "Octobre",
                        EndSeason = "Février",

                        Ingredient0 = "25 Crevettes Roses",
                        Ingredient1 = "6 Topinambours",
                        Ingredient2 = "20 cl de Crème Fraîche",
                        Ingredient3 = "Ciboulette",
                        Ingredient4 = "Sel et Poivre",
                        Ingredient5 = "Beurre",
                        Ingredient6 = "",
                        Ingredient7 = "",
                        Ingredient8 = "",
                        Ingredient9 = "",

                    },


                    new Recipe
                    {
                        Name = "Ballots d'Asperges au Jambon",
                        NumMeal = 2,
                        StartSeason = "Avril",
                        EndSeason = "Juin",

                        Ingredient0 = "16 Asperges",
                        Ingredient1 = "100g de Parmesan",
                        Ingredient2 = "8 Tranches de Jambon",
                        Ingredient3 = "Ciboulette",
                        Ingredient4 = "",
                        Ingredient5 = "",
                        Ingredient6 = "",
                        Ingredient7 = "",
                        Ingredient8 = "",
                        Ingredient9 = "",

                    }
                );
                context.SaveChanges();
            }
        }

    }
}
