using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class removedlockmakeandcodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lock_codes",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lock_make",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lock_codes",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lock_make",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lock_codes",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lock_make",
                table: "Aluminium");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lock_codes",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lock_make",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lock_codes",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lock_make",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lock_codes",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lock_make",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
