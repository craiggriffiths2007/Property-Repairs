using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class itemschanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bMouldingDrawn",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bSashDrawn",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bSectionDrawn",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "b_signed",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "doc_l_compliant",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "doc_l_compliant_reason",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_color",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_color_code",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_color_code_out",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_color_out",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_height",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_thickness",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "door_width",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "draught_strip",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "frame_color",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "frame_color_code",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "new_sash_required",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "pre_glazed_door",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "repair_frame",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "long_comments",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_bSGDesignComplete",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "Aluminium");

            migrationBuilder.RenameColumn(
                name: "WER_rating",
                table: "Timber",
                newName: "WER_Rating");

            migrationBuilder.RenameColumn(
                name: "weather_bar",
                table: "Timber",
                newName: "replace_panel");

            migrationBuilder.RenameColumn(
                name: "timber_wood",
                table: "Timber",
                newName: "upvc_item");

            migrationBuilder.RenameColumn(
                name: "timber_new_frame_req",
                table: "Timber",
                newName: "midrail");

            migrationBuilder.RenameColumn(
                name: "timber_item",
                table: "Timber",
                newName: "threshold_type");

            migrationBuilder.RenameColumn(
                name: "timber_glazed",
                table: "Timber",
                newName: "spacer_colour");

            migrationBuilder.RenameColumn(
                name: "timber_frame_wood",
                table: "Timber",
                newName: "profile_type");

            migrationBuilder.RenameColumn(
                name: "thresher",
                table: "Timber",
                newName: "addons");

            migrationBuilder.RenameColumn(
                name: "standard_sizes",
                table: "Timber",
                newName: "outer_section_size");

            migrationBuilder.RenameColumn(
                name: "spacer_color",
                table: "Timber",
                newName: "midrail_height");

            migrationBuilder.RenameColumn(
                name: "single_double",
                table: "Timber",
                newName: "locking_type");

            migrationBuilder.RenameColumn(
                name: "reasonnonstandard",
                table: "Timber",
                newName: "hinge_colour");

            migrationBuilder.RenameColumn(
                name: "no_of_vids",
                table: "Timber",
                newName: "internal_lock");

            migrationBuilder.RenameColumn(
                name: "no_of_pics",
                table: "Timber",
                newName: "LPHandles");

            migrationBuilder.RenameColumn(
                name: "moulding",
                table: "Timber",
                newName: "handle_colour");

            migrationBuilder.RenameColumn(
                name: "locks",
                table: "Timber",
                newName: "glaze");

            migrationBuilder.RenameColumn(
                name: "lead_CWidths",
                table: "Timber",
                newName: "frame_depth");

            migrationBuilder.RenameColumn(
                name: "lead_CHeights",
                table: "Timber",
                newName: "double_tripple");

            migrationBuilder.RenameColumn(
                name: "hinge_type",
                table: "Timber",
                newName: "colour");

            migrationBuilder.RenameColumn(
                name: "hardware_color",
                table: "Timber",
                newName: "bead_type");

            migrationBuilder.RenameColumn(
                name: "frame_color_out",
                table: "Timber",
                newName: "addon_width");

            migrationBuilder.RenameColumn(
                name: "frame_color_code_out",
                table: "Timber",
                newName: "addon_height");

            migrationBuilder.RenameColumn(
                name: "fire_rated_glass",
                table: "Timber",
                newName: "bPanelComplete");

            migrationBuilder.AlterColumn<string>(
                name: "temporary",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WER_Rating",
                table: "Timber",
                newName: "WER_rating");

            migrationBuilder.RenameColumn(
                name: "upvc_item",
                table: "Timber",
                newName: "timber_wood");

            migrationBuilder.RenameColumn(
                name: "threshold_type",
                table: "Timber",
                newName: "timber_item");

            migrationBuilder.RenameColumn(
                name: "spacer_colour",
                table: "Timber",
                newName: "timber_glazed");

            migrationBuilder.RenameColumn(
                name: "replace_panel",
                table: "Timber",
                newName: "weather_bar");

            migrationBuilder.RenameColumn(
                name: "profile_type",
                table: "Timber",
                newName: "timber_frame_wood");

            migrationBuilder.RenameColumn(
                name: "outer_section_size",
                table: "Timber",
                newName: "standard_sizes");

            migrationBuilder.RenameColumn(
                name: "midrail_height",
                table: "Timber",
                newName: "spacer_color");

            migrationBuilder.RenameColumn(
                name: "midrail",
                table: "Timber",
                newName: "timber_new_frame_req");

            migrationBuilder.RenameColumn(
                name: "locking_type",
                table: "Timber",
                newName: "single_double");

            migrationBuilder.RenameColumn(
                name: "internal_lock",
                table: "Timber",
                newName: "no_of_vids");

            migrationBuilder.RenameColumn(
                name: "hinge_colour",
                table: "Timber",
                newName: "reasonnonstandard");

            migrationBuilder.RenameColumn(
                name: "handle_colour",
                table: "Timber",
                newName: "moulding");

            migrationBuilder.RenameColumn(
                name: "glaze",
                table: "Timber",
                newName: "locks");

            migrationBuilder.RenameColumn(
                name: "frame_depth",
                table: "Timber",
                newName: "lead_CWidths");

            migrationBuilder.RenameColumn(
                name: "double_tripple",
                table: "Timber",
                newName: "lead_CHeights");

            migrationBuilder.RenameColumn(
                name: "colour",
                table: "Timber",
                newName: "hinge_type");

            migrationBuilder.RenameColumn(
                name: "bead_type",
                table: "Timber",
                newName: "hardware_color");

            migrationBuilder.RenameColumn(
                name: "bPanelComplete",
                table: "Timber",
                newName: "fire_rated_glass");

            migrationBuilder.RenameColumn(
                name: "addons",
                table: "Timber",
                newName: "thresher");

            migrationBuilder.RenameColumn(
                name: "addon_width",
                table: "Timber",
                newName: "frame_color_out");

            migrationBuilder.RenameColumn(
                name: "addon_height",
                table: "Timber",
                newName: "frame_color_code_out");

            migrationBuilder.RenameColumn(
                name: "LPHandles",
                table: "Timber",
                newName: "no_of_pics");

            migrationBuilder.AlterColumn<int>(
                name: "temporary",
                table: "Timber",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bMouldingDrawn",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bSashDrawn",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bSectionDrawn",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "b_signed",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "doc_l_compliant",
                table: "Timber",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "doc_l_compliant_reason",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color_code",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color_code_out",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color_out",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_height",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_thickness",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_width",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "draught_strip",
                table: "Timber",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "frame_color",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "frame_color_code",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "new_sash_required",
                table: "Timber",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "pre_glazed_door",
                table: "Timber",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "repair_frame",
                table: "Timber",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Panel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Panel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Panel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Panel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Panel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "long_comments",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Greenhouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Greenhouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Greenhouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Glass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Glass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Glass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Garage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Garage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Garage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Conservatory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Conservatory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Conservatory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Composite",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Composite",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Composite",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Composite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Composite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Composite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Bifolding",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Bifolding",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Bifolding",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "bLockComplete",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bSGDesignComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
