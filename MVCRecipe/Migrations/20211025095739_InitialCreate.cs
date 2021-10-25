using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCRecipe.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumMeal = table.Column<int>(type: "int", nullable: true),
                    StartSeason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndSeason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredient0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient9 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
