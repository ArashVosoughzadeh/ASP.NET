using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItShop.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_orders_OrderId",
                table: "orderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_products_ProductId",
                table: "orderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.RenameTable(
                name: "orderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetail_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetail_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "count",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "count",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "orderDetail",
                newName: "IX_orderDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "orderDetail",
                newName: "IX_orderDetail_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_orders_OrderId",
                table: "orderDetail",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_products_ProductId",
                table: "orderDetail",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
