using Microsoft.EntityFrameworkCore.Migrations;

namespace MuskanChildrenHospitalApp.Migrations
{
    public partial class apCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayementMode",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefrenceId",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "ExpenseReceipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayementMode",
                table: "ExpenseReceipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefrenceId",
                table: "ExpenseReceipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Refund",
                table: "Bills",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "PayementMode",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "RefrenceId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "ExpenseReceipts");

            migrationBuilder.DropColumn(
                name: "PayementMode",
                table: "ExpenseReceipts");

            migrationBuilder.DropColumn(
                name: "RefrenceId",
                table: "ExpenseReceipts");

            migrationBuilder.DropColumn(
                name: "Refund",
                table: "Bills");
        }
    }
}
