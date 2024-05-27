using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicTacToe.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WinStreak",
                table: "Players",
                newName: "WonRounds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WonRounds",
                table: "Players",
                newName: "WinStreak");
        }
    }
}
