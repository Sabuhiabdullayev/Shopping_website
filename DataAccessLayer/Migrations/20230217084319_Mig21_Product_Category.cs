using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig21_Product_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category2Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category2Id",
                table: "Products",
                column: "Category2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category2s_Category2Id",
                table: "Products",
                column: "Category2Id",
                principalTable: "Category2s",
                principalColumn: "Category2Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category2s_Category2Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category2Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category2Id",
                table: "Products");
        }
    }
}
