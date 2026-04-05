using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class suveyortoagent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the old FK so we can rename freely
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Surveyor_SurveyorId",
                table: "Job");

            // Drop the old PK so we can rename the column
            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveyor",
                table: "Surveyor");

            // Rename the table
            migrationBuilder.RenameTable(
                name: "Surveyor",
                newName: "Agent");

            // Rename columns on Agent (formerly Surveyor)
            migrationBuilder.RenameColumn(
                name: "SurveyorId",
                table: "Agent",
                newName: "AgentId");

            migrationBuilder.RenameColumn(
                name: "SurveyorCode",
                table: "Agent",
                newName: "AgentCode");

            // Re-add the PK with the new name
            migrationBuilder.AddPrimaryKey(
                name: "PK_Agent",
                table: "Agent",
                column: "AgentId");

            // Add the new AgentType column (defaults to 0 = Surveyor)
            migrationBuilder.AddColumn<int>(
                name: "AgentType",
                table: "Agent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Rename the FK column on Job
            migrationBuilder.RenameColumn(
                name: "SurveyorId",
                table: "Job",
                newName: "AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_Job_SurveyorId",
                table: "Job",
                newName: "IX_Job_AgentId");

            // Re-add the FK pointing to the renamed table
            migrationBuilder.AddForeignKey(
                name: "FK_Job_Agent_AgentId",
                table: "Job",
                column: "AgentId",
                principalTable: "Agent",
                principalColumn: "AgentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Agent_AgentId",
                table: "Job");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agent",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "AgentType",
                table: "Agent");

            migrationBuilder.RenameTable(
                name: "Agent",
                newName: "Surveyor");

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "Surveyor",
                newName: "SurveyorId");

            migrationBuilder.RenameColumn(
                name: "AgentCode",
                table: "Surveyor",
                newName: "SurveyorCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveyor",
                table: "Surveyor",
                column: "SurveyorId");

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "Job",
                newName: "SurveyorId");

            migrationBuilder.RenameIndex(
                name: "IX_Job_AgentId",
                table: "Job",
                newName: "IX_Job_SurveyorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Surveyor_SurveyorId",
                table: "Job",
                column: "SurveyorId",
                principalTable: "Surveyor",
                principalColumn: "SurveyorId");
        }
    }
}
