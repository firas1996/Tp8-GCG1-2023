﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class withData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverUrl", "Description", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Auther 1", "https://www.book1.com", "Description 1", 3.7000000000000002, "Book 1" },
                    { 2, "Auther 2", "https://www.book2.com", "Description 2", 2.2000000000000002, "Book 2" },
                    { 3, "Auther 3", "https://www.book3.com", "Description 3", 1.0, "Book 3" },
                    { 4, "Auther 4", "https://www.book4.com", "Description 4", 5.0, "Book 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
