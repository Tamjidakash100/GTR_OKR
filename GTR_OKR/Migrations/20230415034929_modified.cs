using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTR_OKR.Migrations
{
    /// <inheritdoc />
    public partial class modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_ComAdminId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ComAdminId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ComAdminId",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Companies",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "ComAdminId",
                table: "Companies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ComAdminId",
                table: "Companies",
                column: "ComAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_ComAdminId",
                table: "Companies",
                column: "ComAdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
