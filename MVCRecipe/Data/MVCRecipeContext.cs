using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCRecipe.Models;

namespace MVCRecipe.Data
{
    public class MVCRecipeContext : DbContext
    {
        public MVCRecipeContext (DbContextOptions<MVCRecipeContext> options)
            : base(options)
        {
        }

        public DbSet<MVCRecipe.Models.Recipe> Recipe { get; set; }
    }
}
