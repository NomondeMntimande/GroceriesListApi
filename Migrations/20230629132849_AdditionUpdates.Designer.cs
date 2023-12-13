﻿// <auto-generated />
using GroceriesListApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GroceriesListApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629132849_AdditionUpdates")]
    partial class AdditionUpdates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GroceriesListApi.Models.Entities.GroceriesList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("categoryListId")
                        .HasColumnType("integer");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("listItemId")
                        .HasColumnType("integer");

                    b.Property<string>("listName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("listOwner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GroceriesList");
                });

            modelBuilder.Entity("GroceriesListApi.Models.Entities.ListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("addedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("bought")
                        .HasColumnType("boolean");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ListItem");
                });
#pragma warning restore 612, 618
        }
    }
}
