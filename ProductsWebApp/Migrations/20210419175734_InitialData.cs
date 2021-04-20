using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsWebApp.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Alias", "Name" },
                values: new object[] { 1, "FIRST", "Категория 1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Alias", "Name" },
                values: new object[] { 2, "SECOND", "Категория 2" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Alias", "Name" },
                values: new object[] { 3, "THIRD", "Категория 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
