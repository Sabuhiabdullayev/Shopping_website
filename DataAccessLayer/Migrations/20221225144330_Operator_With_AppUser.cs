using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Operator_With_AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "OperatorContacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OperatorContacts_AppUserId",
                table: "OperatorContacts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperatorContacts_AspNetUsers_AppUserId",
                table: "OperatorContacts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperatorContacts_AspNetUsers_AppUserId",
                table: "OperatorContacts");

            migrationBuilder.DropIndex(
                name: "IX_OperatorContacts_AppUserId",
                table: "OperatorContacts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "OperatorContacts");
        }
    }
}
