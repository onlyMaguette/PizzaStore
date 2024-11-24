﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaStore.Models;

#nullable disable

namespace PizzaStore.Migrations
{
    [DbContext(typeof(PizzaDb))]
    [Migration("20241124162825_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("PizzaStore.Models.PizzaEhod", b =>
                {
                    b.Property<int>("IdEhod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescriptionEhod")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomEhod")
                        .HasColumnType("TEXT");

                    b.HasKey("IdEhod");

                    b.ToTable("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
