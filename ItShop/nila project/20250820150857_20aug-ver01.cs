using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItShop.Migrations
{
    public partial class _20augver01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityInStook = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CtegoryToProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtegoryToProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CtegoryToProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtegoryToProducts_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ExtraDescription", "Name" },
                values: new object[,]
                {
                    { 1, "IT group3", "", "IT group" },
                    { 2, "گروه لوازم برقی", "", "لوازم برقی" },
                    { 3, "ذخیره فایل", "", "فلش" },
                    { 4, "لوازم کامپیوتر", "", "کیبورد" },
                    { 5, "لواز کامپیوتر", "", "موس" },
                    { 6, "اوازم کامپیوتر", "", "کیس" },
                    { 7, "انواع هارد ", "", "هارد" },
                    { 8, "انواع لپتاپ", "", "لپتاپ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CtegoryToProducts_CategoryId",
                table: "CtegoryToProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CtegoryToProducts_ProductId",
                table: "CtegoryToProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ItemId",
                table: "products",
                column: "ItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CtegoryToProducts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
