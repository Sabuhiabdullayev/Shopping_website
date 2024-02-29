using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig9_OperatorComment_With_AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "OperatorComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OperatorComments_AppUserId",
                table: "OperatorComments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperatorComments_AspNetUsers_AppUserId",
                table: "OperatorComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperatorComments_AspNetUsers_AppUserId",
                table: "OperatorComments");

            migrationBuilder.DropIndex(
                name: "IX_OperatorComments_AppUserId",
                table: "OperatorComments");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "OperatorComments");
        }
    }
}
