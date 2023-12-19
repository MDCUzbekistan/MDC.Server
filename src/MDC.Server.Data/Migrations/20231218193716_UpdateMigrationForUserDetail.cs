using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MDC.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigrationForUserDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDatails_Users_UserId",
                table: "UserDatails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDatails",
                table: "UserDatails");

            migrationBuilder.RenameTable(
                name: "UserDatails",
                newName: "UserDetails");

            migrationBuilder.RenameIndex(
                name: "IX_UserDatails_UserId",
                table: "UserDetails",
                newName: "IX_UserDetails_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_Users_UserId",
                table: "UserDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_Users_UserId",
                table: "UserDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails");

            migrationBuilder.RenameTable(
                name: "UserDetails",
                newName: "UserDatails");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDatails",
                newName: "IX_UserDatails_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDatails",
                table: "UserDatails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDatails_Users_UserId",
                table: "UserDatails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
