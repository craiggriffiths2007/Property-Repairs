using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class removedspecialglass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_height",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_width",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_CHeights",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_CWidths",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_comments",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_height",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_width",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_CHeight",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_CWidth",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_anti_rattle",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_bBackToBackComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_bBarComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_bDiamondComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_bGeorgianComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_comments",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_sizeA",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_sizeB",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_sizeC",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_sizeD",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_sod",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_thickness",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_type",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_height",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_width",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_comments",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_height",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "back_to_back_spacer_width",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_CHeight",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_CHeightf",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_CWidth",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_CWidthf",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_anti_rattle",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_bBackToBackComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_bBarComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_bDiamondComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_bGeorgianComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_comments",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_sizeA",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_sizeB",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_sizeC",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_sizeD",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_sod",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_thickness",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_type",
                table: "Aluminium");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_height",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_width",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "lead_CHeights",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "lead_CWidths",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_comments",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_height",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_width",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lead_CHeight",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "lead_CWidth",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "lead_anti_rattle",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBackToBackComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBarComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bDiamondComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bGeorgianComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "lead_comments",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeA",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeB",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeC",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeD",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "lead_sod",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_thickness",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_type",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "Glass",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "Glass",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_height",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_width",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "Composite",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "Composite",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "lead_comments",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_height",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_to_back_spacer_width",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lead_CHeight",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "lead_CHeightf",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "lead_CWidth",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "lead_CWidthf",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "lead_anti_rattle",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBackToBackComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBarComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bDiamondComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bGeorgianComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "lead_comments",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeA",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeB",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeC",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeD",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "lead_sod",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_thickness",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_type",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
