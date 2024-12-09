using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cptis.infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLogger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Log",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExceptionType",
                table: "Log",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Method",
                table: "Log",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Log",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StackTrace",
                table: "Log",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "ExceptionType",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "Method",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "StackTrace",
                table: "Log");
        }
    }
}
