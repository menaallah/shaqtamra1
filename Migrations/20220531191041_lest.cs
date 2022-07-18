using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class lest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailAddress",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: "DetailAddress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailAddress",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "DetailAddress",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
