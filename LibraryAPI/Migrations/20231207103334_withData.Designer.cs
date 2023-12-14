﻿// <auto-generated />
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20231207103334_withData")]
    partial class withData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Auther 1",
                            CoverUrl = "https://www.book1.com",
                            Description = "Description 1",
                            Rating = 3.7000000000000002,
                            Title = "Book 1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Auther 2",
                            CoverUrl = "https://www.book2.com",
                            Description = "Description 2",
                            Rating = 2.2000000000000002,
                            Title = "Book 2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Auther 3",
                            CoverUrl = "https://www.book3.com",
                            Description = "Description 3",
                            Rating = 1.0,
                            Title = "Book 3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Auther 4",
                            CoverUrl = "https://www.book4.com",
                            Description = "Description 4",
                            Rating = 5.0,
                            Title = "Book 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
