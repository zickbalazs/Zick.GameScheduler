using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zick.GameScheduler.Data.Migrations
{
    /// <inheritdoc />
    public partial class v01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RacerId",
                table: "Registrations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_RacerId",
                table: "Registrations",
                column: "RacerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_AspNetUsers_RacerId",
                table: "Registrations",
                column: "RacerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_AspNetUsers_RacerId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_RacerId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "RacerId",
                table: "Registrations");
        }
    }
}
