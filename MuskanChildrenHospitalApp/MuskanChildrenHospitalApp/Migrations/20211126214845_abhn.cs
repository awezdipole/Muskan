using Microsoft.EntityFrameworkCore.Migrations;

namespace MuskanChildrenHospitalApp.Migrations
{
    public partial class abhn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "AssignRooms",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "AssignRooms");
        }
    }
}
