using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class includesurvey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "bIncludeSurvey",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bIncludeSurvey",
                table: "Job");
        }
    }
}
