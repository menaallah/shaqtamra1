using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Post");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Post",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
