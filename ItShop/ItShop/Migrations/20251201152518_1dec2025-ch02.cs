using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItShop.Migrations
{
    public partial class _1dec2025ch02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "items",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ExtraDescription", "Name" },
                values: new object[,]
                {
                    { 1, "IT group3", "", "IT group" },
                    { 2, "گروه لوازم برقی", "", "" },
                    { 3, "ذخیره فایل", "", "فلش" },
                    { 4, "لوازم کامپیوتر", "", "کیبورد" },
                    { 5, "لواز کامپیوتر", "", "موس" },
                    { 6, "اوازم کامپیوتر", "", "کیس" },
                    { 7, "انواع هارد ", "", "هارد" },
                    { 8, "انواع هارد ", "", "کامپیوتر" },
                    { 9, "انواع کامپیوتر ", "", "کامپیوتر" },
                    { 10, "انواع موبایل ", "", "گوشی" },
                    { 11, "انواع هدفون ", "", "هدفون" },
                    { 12, "انواع تبلت ", "", "تبلت" },
                    { 13, "انواع لپتاپ", "", "لپتاپ" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "QuantityInStock", "price" },
                values: new object[,]
                {
                    { 1, 5, 850.0m },
                    { 2, 8, 8040.0m },
                    { 3, 3, 905.0m }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 2, "اموزش مقدماتی پایتون ", 1, "اموزش پایتون" });

            migrationBuilder.InsertData(
                table: "CtegoryToProducts",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[] { 1, 1, 2 });
        }
    }
}
