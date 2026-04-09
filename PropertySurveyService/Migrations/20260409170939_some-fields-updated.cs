using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class somefieldsupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pr_name",
                table: "BifoldTable",
                newName: "print_name");

            migrationBuilder.RenameColumn(
                name: "ernal_width",
                table: "BifoldTable",
                newName: "internal_width");

            migrationBuilder.RenameColumn(
                name: "ernal_height",
                table: "BifoldTable",
                newName: "internal_height");

            migrationBuilder.RenameColumn(
                name: "ernal_door_colour",
                table: "BifoldTable",
                newName: "internal_door_colour");

            migrationBuilder.RenameColumn(
                name: "color_ernal",
                table: "BifoldTable",
                newName: "color_internal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "print_name",
                table: "BifoldTable",
                newName: "pr_name");

            migrationBuilder.RenameColumn(
                name: "internal_width",
                table: "BifoldTable",
                newName: "ernal_width");

            migrationBuilder.RenameColumn(
                name: "internal_height",
                table: "BifoldTable",
                newName: "ernal_height");

            migrationBuilder.RenameColumn(
                name: "internal_door_colour",
                table: "BifoldTable",
                newName: "ernal_door_colour");

            migrationBuilder.RenameColumn(
                name: "color_internal",
                table: "BifoldTable",
                newName: "color_ernal");
        }
    }
}
