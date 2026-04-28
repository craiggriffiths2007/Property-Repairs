using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class branchname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BranchName",
                table: "Branches",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BranchDescription",
                table: "Branches",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "BranchCode",
                table: "Branches",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Branches",
                newName: "BranchName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Branches",
                newName: "BranchDescription");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Branches",
                newName: "BranchCode");
        }
    }
}
