using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class materialupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "l_fpos1",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_fpos2",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_fpos3",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_fpos4",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_fpos5",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_fpos6",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_fpos7",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype1",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype2",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype3",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype4",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype5",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype6",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_itype7",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "l_num",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_CHeight",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_CWidth",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_anti_rattle",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_sizeA",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_sizeB",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lead_sizeC",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "lock_position",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "glass_design",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_CHeight",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_CHeights",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_CWidths",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_sod",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_thickness",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "lead_type",
                table: "Composite");

            migrationBuilder.RenameColumn(
                name: "right_bolt",
                table: "Frame",
                newName: "no_of_photos");

            migrationBuilder.RenameColumn(
                name: "panel_complete",
                table: "Frame",
                newName: "fire_rated_glass");

            migrationBuilder.RenameColumn(
                name: "lock_make",
                table: "Frame",
                newName: "upvc_item");

            migrationBuilder.RenameColumn(
                name: "lock_codes",
                table: "Frame",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "left_bolt",
                table: "Frame",
                newName: "no_of_drawings");

            migrationBuilder.RenameColumn(
                name: "lead_type",
                table: "Frame",
                newName: "timber_item");

            migrationBuilder.RenameColumn(
                name: "lead_thickness",
                table: "Frame",
                newName: "timber_glazed");

            migrationBuilder.RenameColumn(
                name: "lead_sod",
                table: "Frame",
                newName: "threshold_type");

            migrationBuilder.RenameColumn(
                name: "lead_sizeD",
                table: "Frame",
                newName: "i_spare3");

            migrationBuilder.RenameColumn(
                name: "lead_bGeorgianComplete",
                table: "Frame",
                newName: "b_signed");

            migrationBuilder.RenameColumn(
                name: "lead_bDiamondComplete",
                table: "Frame",
                newName: "bWindowComplete");

            migrationBuilder.RenameColumn(
                name: "lead_bBarComplete",
                table: "Frame",
                newName: "bSectionDrawn");

            migrationBuilder.RenameColumn(
                name: "lead_bBackToBackComplete",
                table: "Frame",
                newName: "bSashDrawn");

            migrationBuilder.RenameColumn(
                name: "lead_CWidths",
                table: "Frame",
                newName: "sub_frame_depth");

            migrationBuilder.RenameColumn(
                name: "lead_CHeights",
                table: "Frame",
                newName: "sub_frame_color");

            migrationBuilder.RenameColumn(
                name: "l_sizeG",
                table: "Frame",
                newName: "standard_sizes");

            migrationBuilder.RenameColumn(
                name: "l_sizeF",
                table: "Frame",
                newName: "single_double");

            migrationBuilder.RenameColumn(
                name: "l_sizeE",
                table: "Frame",
                newName: "section_type");

            migrationBuilder.RenameColumn(
                name: "l_sizeD",
                table: "Frame",
                newName: "reasonnonstandard");

            migrationBuilder.RenameColumn(
                name: "l_sizeC",
                table: "Frame",
                newName: "outer_section_width");

            migrationBuilder.RenameColumn(
                name: "l_sizeB",
                table: "Frame",
                newName: "outer_section_height");

            migrationBuilder.RenameColumn(
                name: "l_sizeA",
                table: "Frame",
                newName: "night_vent");

            migrationBuilder.RenameColumn(
                name: "l_size2",
                table: "Frame",
                newName: "moulding");

            migrationBuilder.RenameColumn(
                name: "l_size1",
                table: "Frame",
                newName: "midrail_type");

            migrationBuilder.RenameColumn(
                name: "item_summary",
                table: "Frame",
                newName: "locks");

            migrationBuilder.RenameColumn(
                name: "frame_width",
                table: "Frame",
                newName: "item_frame_width");

            migrationBuilder.RenameColumn(
                name: "frame_height",
                table: "Frame",
                newName: "item_frame_height");

            migrationBuilder.RenameColumn(
                name: "frame_colour",
                table: "Frame",
                newName: "item_color");

            migrationBuilder.RenameColumn(
                name: "frame_color_out_code",
                table: "Frame",
                newName: "hinge_type");

            migrationBuilder.RenameColumn(
                name: "frame_color_in_code",
                table: "Frame",
                newName: "hinge_colour");

            migrationBuilder.RenameColumn(
                name: "frame_color_in",
                table: "Frame",
                newName: "hardware_color");

            migrationBuilder.RenameColumn(
                name: "door_color_out_code",
                table: "Frame",
                newName: "handle_colour");

            migrationBuilder.RenameColumn(
                name: "door_color_in_code",
                table: "Frame",
                newName: "handle_color");

            migrationBuilder.RenameColumn(
                name: "door_color_in",
                table: "Frame",
                newName: "glazed");

            migrationBuilder.RenameColumn(
                name: "GearBox",
                table: "Frame",
                newName: "frame_type");

            migrationBuilder.RenameColumn(
                name: "lead_bGeorgianComplete",
                table: "Composite",
                newName: "bWindowComplete");

            migrationBuilder.RenameColumn(
                name: "lead_bDiamondComplete",
                table: "Composite",
                newName: "bLockComplete");

            migrationBuilder.RenameColumn(
                name: "lead_bBarComplete",
                table: "Composite",
                newName: "bHandleDrawingComplete");

            migrationBuilder.RenameColumn(
                name: "lead_bBackToBackComplete",
                table: "Composite",
                newName: "bDoorComplete");

            migrationBuilder.RenameColumn(
                name: "lead_anti_rattle",
                table: "Composite",
                newName: "no_of_photos");

            migrationBuilder.RenameColumn(
                name: "lead_CWidth",
                table: "Composite",
                newName: "no_of_drawings");

            migrationBuilder.AddColumn<bool>(
                name: "bComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "bWindowComplete",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<bool>(
                name: "bRepair",
                table: "Panel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Panel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
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
                name: "bHandleDrawingComplete",
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
                name: "bRepair",
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

            migrationBuilder.AddColumn<int>(
                name: "base_item",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
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

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRepair",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Greenhouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
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

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRepair",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Glass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
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

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRepair",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Garage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Garage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "pet_magnetic",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "midrail",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "material",
                table: "Frame",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "is_a_flat",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "internal_lock",
                table: "Frame",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "handles_req",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "doc_l_compliant",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "cosmetic_damage",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "collect_and_copy",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "addons",
                table: "Frame",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LPHandles",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WER_Rating",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "bMouldingDrawn",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bPanelComplete",
                table: "Frame",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "bead_type",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "cill",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cill_type",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cills",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "colour",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color_code",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_color_code_out",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_height",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_thickness",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "door_width",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "draught_strip",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "drip",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "frame_color",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "frame_color_code",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "frame_color_code_out",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "head_drip",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "new_sash_required",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "pre_glazed_door",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "repair_frame",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "thresher",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "timber_new_frame_req",
                table: "Frame",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "weather_bar",
                table: "Frame",
                type: "bit",
                nullable: true);

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

            migrationBuilder.AddColumn<bool>(
                name: "bDoorComplete",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHandleDrawingComplete",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Conservatory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
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
                name: "bDoorComplete",
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

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Bifolding",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
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

            migrationBuilder.AddColumn<bool>(
                name: "bLockComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bWindowComplete",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "no_of_drawings",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "UPVC");

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
                name: "bWindowComplete",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "bRepair",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
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
                name: "bHandleDrawingComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bRepair",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "base_item",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bRepair",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bRepair",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bRepair",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "LPHandles",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "WER_Rating",
                table: "Frame");

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
                name: "bMouldingDrawn",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bPanelComplete",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bead_type",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "cill",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "cill_type",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "cills",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "colour",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "door_color",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "door_color_code",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "door_color_code_out",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "door_height",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "door_thickness",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "door_width",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "draught_strip",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "drip",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "frame_color",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "frame_color_code",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "frame_color_code_out",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "head_drip",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "new_sash_required",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "pre_glazed_door",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "repair_frame",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "thresher",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "timber_new_frame_req",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "weather_bar",
                table: "Frame");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "bComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bDoorComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bHandleDrawingComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bLockComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bWindowComplete",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "no_of_drawings",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
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
                name: "no_of_drawings",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "Aluminium");

            migrationBuilder.RenameColumn(
                name: "upvc_item",
                table: "Frame",
                newName: "lock_make");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Frame",
                newName: "lock_codes");

            migrationBuilder.RenameColumn(
                name: "timber_item",
                table: "Frame",
                newName: "lead_type");

            migrationBuilder.RenameColumn(
                name: "timber_glazed",
                table: "Frame",
                newName: "lead_thickness");

            migrationBuilder.RenameColumn(
                name: "threshold_type",
                table: "Frame",
                newName: "lead_sod");

            migrationBuilder.RenameColumn(
                name: "sub_frame_depth",
                table: "Frame",
                newName: "lead_CWidths");

            migrationBuilder.RenameColumn(
                name: "sub_frame_color",
                table: "Frame",
                newName: "lead_CHeights");

            migrationBuilder.RenameColumn(
                name: "standard_sizes",
                table: "Frame",
                newName: "l_sizeG");

            migrationBuilder.RenameColumn(
                name: "single_double",
                table: "Frame",
                newName: "l_sizeF");

            migrationBuilder.RenameColumn(
                name: "section_type",
                table: "Frame",
                newName: "l_sizeE");

            migrationBuilder.RenameColumn(
                name: "reasonnonstandard",
                table: "Frame",
                newName: "l_sizeD");

            migrationBuilder.RenameColumn(
                name: "outer_section_width",
                table: "Frame",
                newName: "l_sizeC");

            migrationBuilder.RenameColumn(
                name: "outer_section_height",
                table: "Frame",
                newName: "l_sizeB");

            migrationBuilder.RenameColumn(
                name: "no_of_photos",
                table: "Frame",
                newName: "right_bolt");

            migrationBuilder.RenameColumn(
                name: "no_of_drawings",
                table: "Frame",
                newName: "left_bolt");

            migrationBuilder.RenameColumn(
                name: "night_vent",
                table: "Frame",
                newName: "l_sizeA");

            migrationBuilder.RenameColumn(
                name: "moulding",
                table: "Frame",
                newName: "l_size2");

            migrationBuilder.RenameColumn(
                name: "midrail_type",
                table: "Frame",
                newName: "l_size1");

            migrationBuilder.RenameColumn(
                name: "locks",
                table: "Frame",
                newName: "item_summary");

            migrationBuilder.RenameColumn(
                name: "item_frame_width",
                table: "Frame",
                newName: "frame_width");

            migrationBuilder.RenameColumn(
                name: "item_frame_height",
                table: "Frame",
                newName: "frame_height");

            migrationBuilder.RenameColumn(
                name: "item_color",
                table: "Frame",
                newName: "frame_colour");

            migrationBuilder.RenameColumn(
                name: "i_spare3",
                table: "Frame",
                newName: "lead_sizeD");

            migrationBuilder.RenameColumn(
                name: "hinge_type",
                table: "Frame",
                newName: "frame_color_out_code");

            migrationBuilder.RenameColumn(
                name: "hinge_colour",
                table: "Frame",
                newName: "frame_color_in_code");

            migrationBuilder.RenameColumn(
                name: "hardware_color",
                table: "Frame",
                newName: "frame_color_in");

            migrationBuilder.RenameColumn(
                name: "handle_colour",
                table: "Frame",
                newName: "door_color_out_code");

            migrationBuilder.RenameColumn(
                name: "handle_color",
                table: "Frame",
                newName: "door_color_in_code");

            migrationBuilder.RenameColumn(
                name: "glazed",
                table: "Frame",
                newName: "door_color_in");

            migrationBuilder.RenameColumn(
                name: "frame_type",
                table: "Frame",
                newName: "GearBox");

            migrationBuilder.RenameColumn(
                name: "fire_rated_glass",
                table: "Frame",
                newName: "panel_complete");

            migrationBuilder.RenameColumn(
                name: "b_signed",
                table: "Frame",
                newName: "lead_bGeorgianComplete");

            migrationBuilder.RenameColumn(
                name: "bWindowComplete",
                table: "Frame",
                newName: "lead_bDiamondComplete");

            migrationBuilder.RenameColumn(
                name: "bSectionDrawn",
                table: "Frame",
                newName: "lead_bBarComplete");

            migrationBuilder.RenameColumn(
                name: "bSashDrawn",
                table: "Frame",
                newName: "lead_bBackToBackComplete");

            migrationBuilder.RenameColumn(
                name: "no_of_photos",
                table: "Composite",
                newName: "lead_anti_rattle");

            migrationBuilder.RenameColumn(
                name: "no_of_drawings",
                table: "Composite",
                newName: "lead_CWidth");

            migrationBuilder.RenameColumn(
                name: "bWindowComplete",
                table: "Composite",
                newName: "lead_bGeorgianComplete");

            migrationBuilder.RenameColumn(
                name: "bLockComplete",
                table: "Composite",
                newName: "lead_bDiamondComplete");

            migrationBuilder.RenameColumn(
                name: "bHandleDrawingComplete",
                table: "Composite",
                newName: "lead_bBarComplete");

            migrationBuilder.RenameColumn(
                name: "bDoorComplete",
                table: "Composite",
                newName: "lead_bBackToBackComplete");

            migrationBuilder.AlterColumn<int>(
                name: "pet_magnetic",
                table: "Frame",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "midrail",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "material",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "is_a_flat",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "internal_lock",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "handles_req",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "doc_l_compliant",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cosmetic_damage",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "collect_and_copy",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "addons",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos1",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos2",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos3",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos4",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos5",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos6",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos7",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "l_itype1",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype2",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype3",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype4",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype5",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype6",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype7",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_num",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_CHeight",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_CWidth",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_anti_rattle",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeA",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeB",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeC",
                table: "Frame",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "lock_position",
                table: "Frame",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "glass_design",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lead_CHeight",
                table: "Composite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "lead_CHeights",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_CWidths",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_sod",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_thickness",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_type",
                table: "Composite",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
