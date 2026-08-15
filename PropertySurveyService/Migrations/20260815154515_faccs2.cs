using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class faccs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "injuries",
                table: "FAccidents");

            migrationBuilder.DropColumn(
                name: "where_abouts",
                table: "FAccidents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "injuries",
                table: "FAccidents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "where_abouts",
                table: "FAccidents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
