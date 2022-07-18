using Microsoft.EntityFrameworkCore.Migrations;

namespace ShaqTamra.DAL.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_beneficiaryRequest_Order_OrderId",
                table: "beneficiaryRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_volunteerRequest_Order_OrderId",
                table: "volunteerRequest");

            migrationBuilder.DropIndex(
                name: "IX_volunteerRequest_OrderId",
                table: "volunteerRequest");

            migrationBuilder.DropIndex(
                name: "IX_beneficiaryRequest_OrderId",
                table: "beneficiaryRequest");

            migrationBuilder.AlterColumn<string>(
                name: "VolunteerId",
                table: "volunteerRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "volunteerRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OrderId1",
                table: "volunteerRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Volunteer_Id",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DonerId",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Beneficiary_Id",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "beneficiaryRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryId",
                table: "beneficiaryRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OrderId1",
                table: "beneficiaryRequest",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_volunteerRequest_OrderId1",
                table: "volunteerRequest",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_beneficiaryRequest_OrderId1",
                table: "beneficiaryRequest",
                column: "OrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_beneficiaryRequest_Order_OrderId1",
                table: "beneficiaryRequest",
                column: "OrderId1",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_volunteerRequest_Order_OrderId1",
                table: "volunteerRequest",
                column: "OrderId1",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_beneficiaryRequest_Order_OrderId1",
                table: "beneficiaryRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_volunteerRequest_Order_OrderId1",
                table: "volunteerRequest");

            migrationBuilder.DropIndex(
                name: "IX_volunteerRequest_OrderId1",
                table: "volunteerRequest");

            migrationBuilder.DropIndex(
                name: "IX_beneficiaryRequest_OrderId1",
                table: "beneficiaryRequest");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "volunteerRequest");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "beneficiaryRequest");

            migrationBuilder.AlterColumn<int>(
                name: "VolunteerId",
                table: "volunteerRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "volunteerRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Volunteer_Id",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DonerId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Beneficiary_Id",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "beneficiaryRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryId",
                table: "beneficiaryRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_volunteerRequest_OrderId",
                table: "volunteerRequest",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_beneficiaryRequest_OrderId",
                table: "beneficiaryRequest",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_beneficiaryRequest_Order_OrderId",
                table: "beneficiaryRequest",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_volunteerRequest_Order_OrderId",
                table: "volunteerRequest",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
