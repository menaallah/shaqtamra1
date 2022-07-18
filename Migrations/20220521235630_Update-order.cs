using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class Updateorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeneficiaryName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DonerName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "VolunteerId",
                table: "beneficiaryRequest");

            migrationBuilder.RenameColumn(
                name: "VolunteerName",
                table: "Order",
                newName: "Location");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Order",
                newName: "VolunteerName");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DonerName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VolunteerId",
                table: "beneficiaryRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
