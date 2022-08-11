using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeRestaurant.Migrations
{
    public partial class AddReservationPropertyEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelNu",
                table: "Reservations",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Hour",
                table: "Reservations",
                newName: "Time");

            migrationBuilder.AddColumn<int>(
                name: "People",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "People",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Reservations",
                newName: "Hour");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Reservations",
                newName: "TelNu");
        }
    }
}
