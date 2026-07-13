using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class materialfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "cill_on_subframe",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "new_timber_sub_frame",
                table: "Frame",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cill_on_subframe",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "new_timber_sub_frame",
                table: "Frame");
        }
    }
}
