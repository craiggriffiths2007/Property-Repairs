using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class add_job_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobType",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Job_ContractId",
                table: "Job",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Contract_ContractId",
                table: "Job",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Contract_ContractId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_ContractId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "JobType",
                table: "Job");
        }
    }
}
