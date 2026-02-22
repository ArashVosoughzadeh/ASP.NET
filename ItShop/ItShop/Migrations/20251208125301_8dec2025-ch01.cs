using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItShop.Migrations
{
    public partial class _8dec2025ch01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "items",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "items",
                newName: "price");
        }
    }
}
