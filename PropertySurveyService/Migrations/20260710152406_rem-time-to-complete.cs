using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class remtimetocomplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rno_hours",
                table: "JobHeader",
                newName: "RemedialTimeToComplete");

            migrationBuilder.RenameColumn(
                name: "r_fault",
                table: "JobHeader",
                newName: "RemedialFault");

            migrationBuilder.RenameColumn(
                name: "r_comp",
                table: "JobHeader",
                newName: "RemedialCompleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemedialTimeToComplete",
                table: "JobHeader",
                newName: "rno_hours");

            migrationBuilder.RenameColumn(
                name: "RemedialFault",
                table: "JobHeader",
                newName: "r_fault");

            migrationBuilder.RenameColumn(
                name: "RemedialCompleted",
                table: "JobHeader",
                newName: "r_comp");
        }
    }
}
