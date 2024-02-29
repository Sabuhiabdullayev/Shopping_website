using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig36_Referance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductViews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductLikes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductViews_ProductId",
                table: "ProductViews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLikes_ProductId",
                table: "ProductLikes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLikes_Products_ProductId",
                table: "ProductLikes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductViews_Products_ProductId",
                table: "ProductViews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLikes_Products_ProductId",
                table: "ProductLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductViews_Products_ProductId",
                table: "ProductViews");

            migrationBuilder.DropIndex(
                name: "IX_ProductViews_ProductId",
                table: "ProductViews");

            migrationBuilder.DropIndex(
                name: "IX_ProductLikes_ProductId",
                table: "ProductLikes");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductViews");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductLikes");
        }
    }
}
