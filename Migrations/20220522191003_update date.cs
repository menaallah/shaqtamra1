using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class updatedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "volunteerRequest",
                newName: "ResponseDate");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "beneficiaryRequest",
                newName: "ResponseDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "volunteerRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "beneficiaryRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "volunteerRequest");

            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "beneficiaryRequest");

            migrationBuilder.RenameColumn(
                name: "ResponseDate",
                table: "volunteerRequest",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ResponseDate",
                table: "beneficiaryRequest",
                newName: "Date");
        }
    }
}
