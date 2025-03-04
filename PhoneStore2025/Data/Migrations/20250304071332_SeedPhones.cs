using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhoneStore2025.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPhones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Manufacturer", "PhoneModel", "Price" },
                values: new object[,]
                {
                    { 2, "Samsung", "A35", 288.0 },
                    { 3, "Apple", "iPhone 15 Pro Max", 605.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
