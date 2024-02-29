using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig4_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "productComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productComments_ProductId",
                table: "productComments",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_productComments_Products_ProductId",
                table: "productComments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
