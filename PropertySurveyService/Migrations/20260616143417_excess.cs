using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class excess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uc_excess",
                table: "JobHeader");

            migrationBuilder.AddColumn<string>(
                name: "Excess",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Excess",
                table: "Contract",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Excess",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "Excess",
                table: "Contract");

            migrationBuilder.AddColumn<double>(
                name: "uc_excess",
                table: "JobHeader",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
