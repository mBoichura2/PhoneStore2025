using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneStore2025.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Manufacturer", "PhoneModel", "Price" },
                values: new object[] { 1, "Apple", "iPhone 12 Pro Max", 305.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
