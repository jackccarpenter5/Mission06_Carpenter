﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Carpenter.Models;

#nullable disable

namespace Mission06_Carpenter.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20240218220610_AddCopiedToPlex")]
    partial class AddCopiedToPlex
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Mission06_Carpenter.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieCategory")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MovieCopiedToPlex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieDirector")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MovieEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieLentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieNotes")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
