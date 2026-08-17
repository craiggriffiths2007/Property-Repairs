using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class assemblychanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item_frame_height",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "item_frame_width",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "timber_item",
                table: "Frame");

            migrationBuilder.RenameColumn(
                name: "upvc_item",
                table: "Frame",
                newName: "sub_frame_width");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Frame",
                newName: "sub_frame_height");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sub_frame_width",
                table: "Frame",
                newName: "upvc_item");

            migrationBuilder.RenameColumn(
                name: "sub_frame_height",
                table: "Frame",
                newName: "type");

            migrationBuilder.AddColumn<string>(
                name: "item_frame_height",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "item_frame_width",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "timber_item",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
