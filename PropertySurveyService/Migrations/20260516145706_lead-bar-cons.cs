using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class leadbarcons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alum_item_number",
                table: "PanelTable");

            migrationBuilder.DropColumn(
                name: "upvc_item_number",
                table: "PanelTable");

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "ConsTable",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "lead_CHeights",
                table: "ConsTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "ConsTable",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "lead_CWidths",
                table: "ConsTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBarComplete",
                table: "ConsTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bDiamondComplete",
                table: "ConsTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bGeorgianComplete",
                table: "ConsTable",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "ConsTable");

            migrationBuilder.DropColumn(
                name: "lead_CHeights",
                table: "ConsTable");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "ConsTable");

            migrationBuilder.DropColumn(
                name: "lead_CWidths",
                table: "ConsTable");

            migrationBuilder.DropColumn(
                name: "lead_bBarComplete",
                table: "ConsTable");

            migrationBuilder.DropColumn(
                name: "lead_bDiamondComplete",
                table: "ConsTable");

            migrationBuilder.DropColumn(
                name: "lead_bGeorgianComplete",
                table: "ConsTable");

            migrationBuilder.AddColumn<int>(
                name: "alum_item_number",
                table: "PanelTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "upvc_item_number",
                table: "PanelTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
