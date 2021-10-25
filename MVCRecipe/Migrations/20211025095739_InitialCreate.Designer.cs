﻿// <auto-generated />
using System;
using MVCRecipe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCRecipe.Migrations
{
    [DbContext(typeof(MVCRecipeContext))]
    [Migration("20211025095739_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCRecipe.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumMeal")
                        .HasColumnType("int");

                    b.Property<string>("StartSeason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndSeason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");



                    b.HasKey("Id");

                    b.ToTable("Recipe");
                });
#pragma warning restore 612, 618
        }
    }
}
