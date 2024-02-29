using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig27_AppUser_MemberSpecialWebSiteAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemberDescription",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberFacebookWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberInstagramWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberSpecialWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberTiktokWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberDescription",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberFacebookWebSite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberInstagramWebSite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberSpecialWebSite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberTiktokWebSite",
                table: "AspNetUsers");
        }
    }
}
