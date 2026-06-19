using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class remediaworkreason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "r_work_txt",
                table: "JobHeader",
                newName: "RemedialWorkReason");

            migrationBuilder.AddColumn<string>(
                name: "RemedialWork",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemedialWork",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "RemedialWorkReason",
                table: "JobHeader",
                newName: "r_work_txt");
        }
    }
}
