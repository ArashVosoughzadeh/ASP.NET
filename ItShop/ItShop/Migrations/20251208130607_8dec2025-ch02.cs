using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItShop.Migrations
{
    public partial class _8dec2025ch02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_items_ItemId",
                table: "products");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropIndex(
                name: "IX_products_ItemId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "products",
                newName: "Quantity");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "products",
                newName: "ItemId");

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_ItemId",
                table: "products",
                column: "ItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_items_ItemId",
                table: "products",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
