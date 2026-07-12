using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class marksoutoften : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "marks_out_of_10",
                table: "FitterVans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "marks_out_of_10",
                table: "FitterVans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
