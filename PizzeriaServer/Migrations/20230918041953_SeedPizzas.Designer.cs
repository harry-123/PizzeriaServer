﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzeriaServer.DbContext;

#nullable disable

namespace PizzeriaServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230918041953_SeedPizzas")]
    partial class SeedPizzas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PizzeriaServer.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzeriaServer.Models.PizzaPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.HasIndex("SizeId")
                        .IsUnique();

                    b.ToTable("PizzaPrices");
                });

            modelBuilder.Entity("PizzeriaServer.Models.PizzaSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PizzaSizes");
                });

            modelBuilder.Entity("PizzeriaServer.Models.PizzaPrice", b =>
                {
                    b.HasOne("PizzeriaServer.Models.Pizza", "Pizza")
                        .WithMany("Prices")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzeriaServer.Models.PizzaSize", "PizzaSize")
                        .WithOne("Price")
                        .HasForeignKey("PizzeriaServer.Models.PizzaPrice", "SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");

                    b.Navigation("PizzaSize");
                });

            modelBuilder.Entity("PizzeriaServer.Models.Pizza", b =>
                {
                    b.Navigation("Prices");
                });

            modelBuilder.Entity("PizzeriaServer.Models.PizzaSize", b =>
                {
                    b.Navigation("Price")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
