using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicTacToe.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxScore",
                table: "Players");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserName",
                table: "Players",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Players_UserName",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "MaxScore",
                table: "Players",
                type: "int",
                nullable: true);
        }
    }
}
