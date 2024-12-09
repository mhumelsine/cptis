using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cptis.infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class updateLogger2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StackTrace",
                table: "Log",
                newName: "Stacktrace");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stacktrace",
                table: "Log",
                newName: "StackTrace");
        }
    }
}
