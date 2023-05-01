using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Layali.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Colour", "Description", "ListPrice", "Price", "Price100", "Price50", "Style" },
                values: new object[,]
                {
                    { 1, "LightBlue", "NEED SOME INFO HERE HUMAA BAJIII... . ", 99.0, 90.0, 80.0, 85.0, "Summer dress" },
                    { 2, "Black", "NEED SOME INFO HERE HUMAA BAJIII... . ", 40.0, 30.0, 20.0, 25.0, "Winter dress " },
                    { 3, "Vanilla", "NEED SOME INFO HERE HUMAA BAJIII... . ", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { 4, "Purple", "NEED SOME INFO HERE HUMAA BAJIII... . ", 70.0, 65.0, 55.0, 60.0, "Abby Muscles" },
                    { 5, "Green", "NEED SOME INFO HERE HUMAA BAJIII... . ", 30.0, 27.0, 20.0, 25.0, "Ron Parker" },
                    { 6, "Blue", "NEED SOME INFO HERE HUMAA BAJIII... . ", 25.0, 23.0, 20.0, 22.0, "Laura Phantom" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
