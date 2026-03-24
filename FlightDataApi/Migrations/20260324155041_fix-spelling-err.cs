using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightDataApi.Migrations
{
    /// <inheritdoc />
    public partial class fixspellingerr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flgihts",
                table: "Flgihts");

            migrationBuilder.RenameTable(
                name: "Flgihts",
                newName: "Flights");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "Flgihts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flgihts",
                table: "Flgihts",
                column: "Id");
        }
    }
}
