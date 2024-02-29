using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig30_Ads_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Img4",
                table: "Ads",
                newName: "AdsStatus");

            migrationBuilder.AddColumn<DateTime>(
                name: "AdsDate",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdsDate",
                table: "Ads");

            migrationBuilder.RenameColumn(
                name: "AdsStatus",
                table: "Ads",
                newName: "Img4");
        }
    }
}
