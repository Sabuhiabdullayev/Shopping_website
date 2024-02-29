using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig15_Database_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperatorComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperatorComments",
                columns: table => new
                {
                    OperatorCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    OperatorCommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperatorCommentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatorCommentSurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatorCommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorComments", x => x.OperatorCommentId);
                    table.ForeignKey(
                        name: "FK_OperatorComments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperatorComments_AppUserId",
                table: "OperatorComments",
                column: "AppUserId");
        }
    }
}
