using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MDC.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ParentIdMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Communities_Communities_ParentId",
                table: "Communities");

            migrationBuilder.DropIndex(
                name: "IX_Communities_ParentId",
                table: "Communities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Communities_ParentId",
                table: "Communities",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Communities_Communities_ParentId",
                table: "Communities",
                column: "ParentId",
                principalTable: "Communities",
                principalColumn: "Id");
        }
    }
}
