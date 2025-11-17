using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItShop.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "items",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "QuantityInStook", "price" },
                values: new object[] { 1, 5, 850.0m });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "QuantityInStook", "price" },
                values: new object[] { 2, 8, 8040.0m });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "QuantityInStook", "price" },
                values: new object[] { 3, 3, 905.0m });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "ItemId", "Name", "description" },
                values: new object[] { 2, 1, "اموزش پایتون", "اموزش مقدماتی پایتون " });

            migrationBuilder.InsertData(
                table: "CtegoryToProducts",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[] { 1, 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CtegoryToProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");
        }
    }
}
