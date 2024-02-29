using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Mig28_SopWebsiteAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopMemberFacebookWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopMemberInstagramWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopMemberSpecialWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopMemberTiktokWebSite",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopMemberFacebookWebSite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShopMemberInstagramWebSite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShopMemberSpecialWebSite",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShopMemberTiktokWebSite",
                table: "AspNetUsers");
        }
    }
}
