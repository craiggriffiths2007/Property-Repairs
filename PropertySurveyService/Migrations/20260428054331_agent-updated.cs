using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class agentupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AgentType",
                table: "Agent",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "AgentCode",
                table: "Agent",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "Agent",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Agent",
                newName: "AgentType");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Agent",
                newName: "AgentCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Agent",
                newName: "AgentId");
        }
    }
}
