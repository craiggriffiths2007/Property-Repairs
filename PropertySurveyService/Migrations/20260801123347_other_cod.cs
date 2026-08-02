using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class other_cod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "funfinoth",
                table: "JobHeader",
                newName: "OtherCauseOfDamage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OtherCauseOfDamage",
                table: "JobHeader",
                newName: "funfinoth");
        }
    }
}
