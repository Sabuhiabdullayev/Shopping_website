using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig13_ProductComment_With_AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "productComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productComments_Id",
                table: "productComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productComments_AspNetUsers_Id",
                table: "productComments",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productComments_AspNetUsers_Id",
                table: "productComments");

            migrationBuilder.DropIndex(
                name: "IX_productComments_Id",
                table: "productComments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "productComments");
        }
    }
}
