﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizzeria;

namespace Pizzeria.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Pizzeria.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pizzeria.models.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Pizzeria.Models.Order", b =>
                {
                    b.OwnsMany("Pizzeria.Models.OrderLine", "OrderLines", b1 =>
                        {
                            b1.Property<Guid>("OrderId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Count")
                                .HasColumnType("INTEGER");

                            b1.Property<Guid>("PizzaId")
                                .HasColumnType("TEXT");

                            b1.Property<decimal>("Price")
                                .HasColumnType("TEXT");

                            b1.HasKey("OrderId", "Id");

                            b1.HasIndex("PizzaId");

                            b1.ToTable("OrderLine");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");

                            b1.HasOne("Pizzeria.models.Pizza", "Pizza")
                                .WithMany()
                                .HasForeignKey("PizzaId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
