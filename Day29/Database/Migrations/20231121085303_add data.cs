using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { new Guid("2fc94449-99cb-481e-826f-633af1e38981"), "Buah", "Ini category Buah" },
                    { new Guid("d4181d3c-1e2f-4ed9-8f16-1bade0cc3c8e"), "Handphone", "Ini category Handphone" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ProductName" },
                values: new object[,]
                {
                    { new Guid("7f0809f6-c836-40fd-bf40-2f43c6a48d36"), new Guid("2fc94449-99cb-481e-826f-633af1e38981"), "Ini Pisang", "Pisang" },
                    { new Guid("ed473b45-1055-4513-8b1b-c50a697ed387"), new Guid("d4181d3c-1e2f-4ed9-8f16-1bade0cc3c8e"), "Ini xiaomi", "Xiaomi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7f0809f6-c836-40fd-bf40-2f43c6a48d36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ed473b45-1055-4513-8b1b-c50a697ed387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fc94449-99cb-481e-826f-633af1e38981"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d4181d3c-1e2f-4ed9-8f16-1bade0cc3c8e"));
        }
    }
}
