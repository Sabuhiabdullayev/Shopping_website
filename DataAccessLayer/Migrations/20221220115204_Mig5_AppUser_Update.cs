using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig5_AppUser_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "productComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FinCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "YourAge",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_productComments_ProductId",
                table: "productComments",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_productComments_Products_ProductId",
                table: "productComments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productComments_Products_ProductId",
                table: "productComments");

            migrationBuilder.DropIndex(
                name: "IX_productComments_ProductId",
                table: "productComments");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "productComments");

            migrationBuilder.DropColumn(
                name: "FinCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "YourAge",
                table: "AspNetUsers");
        }
    }
}
