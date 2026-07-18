using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class fenca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "UPVC",
                newName: "bFensa");

            migrationBuilder.RenameColumn(
                name: "Fensa",
                table: "Timber",
                newName: "bFensa");

            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "Conservatory",
                newName: "bFensa");

            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "Composite",
                newName: "bFensa");

            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "Bifolding",
                newName: "bFensa");

            migrationBuilder.RenameColumn(
                name: "bFencer",
                table: "Aluminium",
                newName: "bFensa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bFensa",
                table: "UPVC",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFensa",
                table: "Timber",
                newName: "Fensa");

            migrationBuilder.RenameColumn(
                name: "bFensa",
                table: "Conservatory",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFensa",
                table: "Composite",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFensa",
                table: "Bifolding",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFensa",
                table: "Aluminium",
                newName: "bFencer");
        }
    }
}
