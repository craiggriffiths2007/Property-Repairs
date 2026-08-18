using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class assemblyupdates5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Frame",
                table: "Frame");

            migrationBuilder.RenameTable(
                name: "Frame",
                newName: "Assembly");

            migrationBuilder.RenameColumn(
                name: "b_signed",
                table: "Assembly",
                newName: "bTimberColoursSigned");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assembly",
                table: "Assembly",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Assembly",
                table: "Assembly");

            migrationBuilder.RenameTable(
                name: "Assembly",
                newName: "Frame");

            migrationBuilder.RenameColumn(
                name: "bTimberColoursSigned",
                table: "Frame",
                newName: "b_signed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Frame",
                table: "Frame",
                column: "Id");
        }
    }
}
