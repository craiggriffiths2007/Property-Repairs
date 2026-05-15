using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class agentcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nsn",
                table: "Header",
                newName: "AgentCode");

            migrationBuilder.RenameColumn(
                name: "bDone",
                table: "Header",
                newName: "bComplete");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bComplete",
                table: "Header",
                newName: "bDone");

            migrationBuilder.RenameColumn(
                name: "AgentCode",
                table: "Header",
                newName: "nsn");
        }
    }
}
