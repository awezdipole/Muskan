using Microsoft.EntityFrameworkCore.Migrations;

namespace MuskanChildrenHospitalApp.Migrations
{
    public partial class newfieldadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmtInWords",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagnosis",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmtInWords",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "Diagnosis",
                table: "Bills");
        }
    }
}
