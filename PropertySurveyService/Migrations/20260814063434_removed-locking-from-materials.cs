using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class removedlockingfrommaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "l_fpos1",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_fpos2",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_fpos3",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_fpos4",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_fpos5",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_fpos6",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_fpos7",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype1",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype2",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype3",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype4",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype5",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype6",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_itype7",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_num",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_size1",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_size2",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeA",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeB",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeC",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeD",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeE",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeF",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "l_sizeG",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_CHeight",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_CWidth",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_anti_rattle",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_bBackToBackComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_bBarComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_bDiamondComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_bGeorgianComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_bSGDesignComplete",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_sizeA",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_sizeB",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_sizeC",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_sizeD",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_sod",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_thickness",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lead_type",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "lock_position",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "no_of_photos",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "no_of_pics",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "no_of_vids",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "LPHandles",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "addon_height",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "internal_lock",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos1",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos2",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos3",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos4",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos5",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos6",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos7",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype1",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype2",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype3",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype4",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype5",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype6",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_itype7",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_num",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "lock_position",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "l_fpos1",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_fpos2",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_fpos3",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_fpos4",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_fpos5",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_fpos6",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_fpos7",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype1",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype2",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype3",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype4",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype5",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype6",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_itype7",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_num",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_size1",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_size2",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeA",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeB",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeC",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeD",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeE",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeF",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "l_sizeG",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_CHeights",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lead_CWidths",
                table: "Aluminium");

            migrationBuilder.DropColumn(
                name: "lock_position",
                table: "Aluminium");

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
                name: "l_sizeG",
                table: "Timber",
                newName: "reasonnonstandard");

            migrationBuilder.RenameColumn(
                name: "l_sizeF",
                table: "Timber",
                newName: "moulding");

            migrationBuilder.RenameColumn(
                name: "l_sizeE",
                table: "Timber",
                newName: "locks");

            migrationBuilder.RenameColumn(
                name: "l_sizeD",
                table: "Timber",
                newName: "hinge_type");

            migrationBuilder.RenameColumn(
                name: "l_sizeC",
                table: "Timber",
                newName: "hardware_color");

            migrationBuilder.RenameColumn(
                name: "l_sizeB",
                table: "Timber",
                newName: "frame_color_out");

            migrationBuilder.RenameColumn(
                name: "l_sizeA",
                table: "Timber",
                newName: "frame_color_code_out");

            migrationBuilder.RenameColumn(
                name: "l_size2",
                table: "Timber",
                newName: "frame_color_code");

            migrationBuilder.RenameColumn(
                name: "l_size1",
                table: "Timber",
                newName: "frame_color");

            migrationBuilder.RenameColumn(
                name: "hinge_colour",
                table: "Timber",
                newName: "door_width");

            migrationBuilder.RenameColumn(
                name: "handle_colour",
                table: "Timber",
                newName: "door_thickness");

            migrationBuilder.RenameColumn(
                name: "glaze",
                table: "Timber",
                newName: "door_height");

            migrationBuilder.RenameColumn(
                name: "frame_depth",
                table: "Timber",
                newName: "door_color_out");

            migrationBuilder.RenameColumn(
                name: "double_tripple",
                table: "Timber",
                newName: "door_color_code_out");

            migrationBuilder.RenameColumn(
                name: "colour",
                table: "Timber",
                newName: "door_color_code");

            migrationBuilder.RenameColumn(
                name: "bead_type",
                table: "Timber",
                newName: "door_color");

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
                newName: "doc_l_compliant_reason");

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

            migrationBuilder.AddColumn<bool>(
                name: "draught_strip",
                table: "Timber",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "new_sash_required",
                table: "Timber",
                type: "bit",
                nullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "temporary",
                table: "Frame",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "b_signed",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "doc_l_compliant",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "draught_strip",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "new_sash_required",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "pre_glazed_door",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "repair_frame",
                table: "Timber");

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
                newName: "l_sizeG");

            migrationBuilder.RenameColumn(
                name: "moulding",
                table: "Timber",
                newName: "l_sizeF");

            migrationBuilder.RenameColumn(
                name: "locks",
                table: "Timber",
                newName: "l_sizeE");

            migrationBuilder.RenameColumn(
                name: "hinge_type",
                table: "Timber",
                newName: "l_sizeD");

            migrationBuilder.RenameColumn(
                name: "hardware_color",
                table: "Timber",
                newName: "l_sizeC");

            migrationBuilder.RenameColumn(
                name: "frame_color_out",
                table: "Timber",
                newName: "l_sizeB");

            migrationBuilder.RenameColumn(
                name: "frame_color_code_out",
                table: "Timber",
                newName: "l_sizeA");

            migrationBuilder.RenameColumn(
                name: "frame_color_code",
                table: "Timber",
                newName: "l_size2");

            migrationBuilder.RenameColumn(
                name: "frame_color",
                table: "Timber",
                newName: "l_size1");

            migrationBuilder.RenameColumn(
                name: "fire_rated_glass",
                table: "Timber",
                newName: "bPanelComplete");

            migrationBuilder.RenameColumn(
                name: "door_width",
                table: "Timber",
                newName: "hinge_colour");

            migrationBuilder.RenameColumn(
                name: "door_thickness",
                table: "Timber",
                newName: "handle_colour");

            migrationBuilder.RenameColumn(
                name: "door_height",
                table: "Timber",
                newName: "glaze");

            migrationBuilder.RenameColumn(
                name: "door_color_out",
                table: "Timber",
                newName: "frame_depth");

            migrationBuilder.RenameColumn(
                name: "door_color_code_out",
                table: "Timber",
                newName: "double_tripple");

            migrationBuilder.RenameColumn(
                name: "door_color_code",
                table: "Timber",
                newName: "colour");

            migrationBuilder.RenameColumn(
                name: "door_color",
                table: "Timber",
                newName: "bead_type");

            migrationBuilder.RenameColumn(
                name: "doc_l_compliant_reason",
                table: "Timber",
                newName: "addon_width");

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

            migrationBuilder.AddColumn<float>(
                name: "l_fpos1",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos2",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos3",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos4",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos5",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos6",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos7",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "l_itype1",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype2",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype3",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype4",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype5",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype6",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype7",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_num",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "l_size1",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_size2",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeA",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeB",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeC",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeD",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeE",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeF",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeG",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lead_CHeight",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_CWidth",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_anti_rattle",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBackToBackComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bBarComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bDiamondComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bGeorgianComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lead_bSGDesignComplete",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeA",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeB",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeC",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lead_sizeD",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "lead_sod",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_thickness",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_type",
                table: "UPVC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lock_position",
                table: "UPVC",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "no_of_photos",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_pics",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_vids",
                table: "UPVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LPHandles",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "addon_height",
                table: "Timber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "internal_lock",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos1",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos2",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos3",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos4",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos5",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos6",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos7",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "l_itype1",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype2",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype3",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype4",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype5",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype6",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype7",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_num",
                table: "Timber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "lock_position",
                table: "Timber",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "temporary",
                table: "Frame",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<float>(
                name: "l_fpos1",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos2",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos3",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos4",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos5",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos6",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "l_fpos7",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "l_itype1",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype2",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype3",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype4",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype5",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype6",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype7",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_num",
                table: "Aluminium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "l_size1",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_size2",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeA",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeB",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeC",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeD",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeE",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeF",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_sizeG",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_CHeights",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lead_CWidths",
                table: "Aluminium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "lock_position",
                table: "Aluminium",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
