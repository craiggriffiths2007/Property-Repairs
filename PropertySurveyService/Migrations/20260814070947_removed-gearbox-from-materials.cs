using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class removedgearboxfrommaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GearBox",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "left_bolt",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "right_bolt",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "GearBox",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "left_bolt",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "right_bolt",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "GearBox",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "left_bolt",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "right_bolt",
                table: "Aluminium");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GearBox",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "left_bolt",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "right_bolt",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GearBox",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "left_bolt",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "right_bolt",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GearBox",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "left_bolt",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "right_bolt",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
