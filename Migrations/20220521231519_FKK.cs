using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class FKK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VolunteerId",
                table: "Order",
                newName: "Volunteer_Id");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryId",
                table: "Order",
                newName: "Beneficiary_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Volunteer_Id",
                table: "Order",
                newName: "VolunteerId");

            migrationBuilder.RenameColumn(
                name: "Beneficiary_Id",
                table: "Order",
                newName: "BeneficiaryId");
        }
    }
}
