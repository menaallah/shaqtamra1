using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailAddress",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailAddress",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "DetailAddress",
                table: "AspNetUsers");
        }
    }
}
