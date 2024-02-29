using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class _23_UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComplaint_Products_ProductId",
                table: "ProductComplaint");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductComplaint",
                table: "ProductComplaint");

            migrationBuilder.RenameTable(
                name: "ProductComplaint",
                newName: "productComplaints");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComplaint_ProductId",
                table: "productComplaints",
                newName: "IX_productComplaints_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productComplaints",
                table: "productComplaints",
                column: "ComplaintId");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_productComplaints_Products_ProductId",
                table: "productComplaints",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productComplaints_Products_ProductId",
                table: "productComplaints");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productComplaints",
                table: "productComplaints");

            migrationBuilder.RenameTable(
                name: "productComplaints",
                newName: "ProductComplaint");

            migrationBuilder.RenameIndex(
                name: "IX_productComplaints_ProductId",
                table: "ProductComplaint",
                newName: "IX_ProductComplaint_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductComplaint",
                table: "ProductComplaint",
                column: "ComplaintId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComplaint_Products_ProductId",
                table: "ProductComplaint",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
