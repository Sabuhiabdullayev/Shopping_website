using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig8_OperatorComment_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperatorComments",
                columns: table => new
                {
                    OperatorCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatorCommentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatorCommentSurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatorCommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatorCommentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorComments", x => x.OperatorCommentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperatorComments");
        }
    }
}
