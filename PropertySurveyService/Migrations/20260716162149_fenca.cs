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
                newName: "bFenca");

            migrationBuilder.RenameColumn(
                name: "Fensa",
                table: "Timber",
                newName: "bFenca");

            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "Conservatory",
                newName: "bFenca");

            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "Composite",
                newName: "bFenca");

            migrationBuilder.RenameColumn(
                name: "fensa",
                table: "Bifolding",
                newName: "bFenca");

            migrationBuilder.RenameColumn(
                name: "bFencer",
                table: "Aluminium",
                newName: "bFenca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bFenca",
                table: "UPVC",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFenca",
                table: "Timber",
                newName: "Fensa");

            migrationBuilder.RenameColumn(
                name: "bFenca",
                table: "Conservatory",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFenca",
                table: "Composite",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFenca",
                table: "Bifolding",
                newName: "fensa");

            migrationBuilder.RenameColumn(
                name: "bFenca",
                table: "Aluminium",
                newName: "bFencer");
        }
    }
}
