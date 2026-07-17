using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class summaryadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "new_locking_mech",
                table: "Frame");

            migrationBuilder.RenameColumn(
                name: "long_comments",
                table: "UPVC",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "long_timber_comments",
                table: "Timber",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "long_sptext",
                table: "Panel",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "comments",
                table: "Lockmech",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "summary",
                table: "Greenhouse",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "long_comments",
                table: "Glass",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "long_comments",
                table: "Garage",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "long_comments",
                table: "Conservatory",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "comments",
                table: "Composite",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "comments",
                table: "Bifolding",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "long_comments",
                table: "Aluminium",
                newName: "Summary");

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginal",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Frame");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "UPVC",
                newName: "long_comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Timber",
                newName: "long_timber_comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Panel",
                newName: "long_sptext");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Lockmech",
                newName: "comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Greenhouse",
                newName: "summary");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Glass",
                newName: "long_comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Garage",
                newName: "long_comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Conservatory",
                newName: "long_comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Composite",
                newName: "comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Bifolding",
                newName: "comments");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Aluminium",
                newName: "long_comments");

            migrationBuilder.AddColumn<int>(
                name: "new_locking_mech",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
