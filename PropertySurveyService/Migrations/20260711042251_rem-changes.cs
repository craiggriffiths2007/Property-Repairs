using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class remchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "readdtxt",
                table: "JobHeader",
                newName: "RemedialReasonExcessNotPaid");

            migrationBuilder.AddColumn<string>(
                name: "RemedialAdditionalInformation",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RemedialComments",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "bRemedialAdditionalImage",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRemedialCompletionFormComplete",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRemedialCustomerSigned",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRemedialExcessPaid",
                table: "JobHeader",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemedialAdditionalInformation",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "RemedialComments",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRemedialAdditionalImage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRemedialCompletionFormComplete",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRemedialCustomerSigned",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRemedialExcessPaid",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "RemedialReasonExcessNotPaid",
                table: "JobHeader",
                newName: "readdtxt");
        }
    }
}
