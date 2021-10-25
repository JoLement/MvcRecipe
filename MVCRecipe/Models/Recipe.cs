using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCRecipe.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int NumMeal { get; set; }
 
        public string StartSeason { get; set; }

        public string EndSeason { get; set; }

        public string Ingredient0 { get; set; }
        public string Ingredient1 { get; set; }
        public string Ingredient2 { get; set; }
        public string Ingredient3 { get; set; }

        public string Ingredient4 { get; set; }
        public string Ingredient5 { get; set; }

        public string Ingredient6 { get; set; }
        public string Ingredient7 { get; set; }
        public string Ingredient8 { get; set; }
        public string Ingredient9 { get; set; }


    }
}
