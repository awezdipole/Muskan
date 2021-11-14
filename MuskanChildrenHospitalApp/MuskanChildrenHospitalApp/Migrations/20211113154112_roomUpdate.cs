using Microsoft.EntityFrameworkCore.Migrations;

namespace MuskanChildrenHospitalApp.Migrations
{
    public partial class roomUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAssign",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAssign",
                table: "Rooms");
        }
    }
}
