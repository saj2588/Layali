using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Layali.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyrecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Country", "Name", "PhoneNumber", "PostCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Doha", null, "Valencia International", "457854", "ig38bb", "Qatar", "123 norway" },
                    { 2, "Doha", null, "Technology Services", "457854", "ig38bb", "Qatar", "575 jhelum" },
                    { 3, "Doha", null, "Bakery Ingredients", "457854", "ig38bb", "Qatar", "778 dubai" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
