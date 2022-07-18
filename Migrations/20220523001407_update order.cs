using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class updateorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "beneficiaryRequest");

            migrationBuilder.DropColumn(
                name: "State",
                table: "beneficiaryRequest");

            migrationBuilder.RenameColumn(
                name: "ResponseDate",
                table: "beneficiaryRequest",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "beneficiaryRequest",
                newName: "ResponseDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "beneficiaryRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "beneficiaryRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
