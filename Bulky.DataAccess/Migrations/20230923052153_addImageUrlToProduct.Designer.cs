﻿// <auto-generated />
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230923052153_addImageUrlToProduct")]
    partial class addImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Billy Spark",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. praesent Molw",
                            ISBN = "SJJ0999999",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Fortune of Time"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Billy Spark second",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. praesent Molw second.",
                            ISBN = "SJJ7999099",
                            ImageUrl = "",
                            ListPrice = 199.0,
                            Price = 190.0,
                            Price100 = 180.0,
                            Price50 = 185.0,
                            Title = "Fortune of Time second"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Billy Spark third",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. praesent Molw third",
                            ISBN = "SJJ7999999",
                            ImageUrl = "",
                            ListPrice = 299.0,
                            Price = 290.0,
                            Price100 = 280.0,
                            Price50 = 285.0,
                            Title = "Fortune of Time third"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Billy Spark fourth",
                            CategoryId = 2,
                            Description = "Praesent vitae sodales libero. praesent Molw fourth",
                            ISBN = "SEEJJ7999999",
                            ImageUrl = "",
                            ListPrice = 399.0,
                            Price = 390.0,
                            Price100 = 380.0,
                            Price50 = 385.0,
                            Title = "Fortune of Time fourth"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Billy Spark fifth",
                            CategoryId = 2,
                            Description = "Praesent vitae sodales libero. praesent Molw fifth",
                            ISBN = "SJJ79999999",
                            ImageUrl = "",
                            ListPrice = 499.0,
                            Price = 490.0,
                            Price100 = 480.0,
                            Price50 = 485.0,
                            Title = "Fortune of Time fifth"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Billy Spark sixth",
                            CategoryId = 3,
                            Description = "Praesent vitae sodales libero. praesent Molw sixth",
                            ISBN = "SJJZ7999999",
                            ImageUrl = "",
                            ListPrice = 599.0,
                            Price = 590.0,
                            Price100 = 580.0,
                            Price50 = 585.0,
                            Title = "Fortune of Time sixth"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.HasOne("Bulky.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
