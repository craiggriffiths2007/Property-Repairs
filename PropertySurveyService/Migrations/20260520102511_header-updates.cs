using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class headerupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "COD_Code",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "SSRequired",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bInfoSeen",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bcodchanged",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "f1_or_s2",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "f_add_txt",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "faddmuch",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "faddpaid",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fbunfinother",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fexcess",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fexcessoth",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fitter_info_done",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fjobfin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fmand",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fmandoth",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fmclrf",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fmdate",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fpartreq",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "freuntxt",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "funfincode",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "height_res",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "is_halifax",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "is_messagetoinsurer",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "issue_no",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ladder_req",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "messagetoinsurer",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "new_ispare1",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "new_ispare2",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "new_sspare9",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "parttxt",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "r_bcomp",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "r_comp",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "r_excess",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "r_sigimage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "r_sign_date",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "rcodchanged",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "refmessage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "remedial_number",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "truecomm",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "truecommconf",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "udi_estrem",
                table: "JobHeader",
                newName: "size_of_barriers_required");

            migrationBuilder.RenameColumn(
                name: "rexcedit",
                table: "JobHeader",
                newName: "excess_ammount_str");

            migrationBuilder.AlterColumn<bool>(
                name: "work_on_public_footpath",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "work_at_height",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "shop_front_work",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "parking_at_rear",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "obs_wires",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "no_ladders",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "loose_brick",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "lintel_present",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "items_above_roof",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "easy_park",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "bWorkInside",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "asbestos_visible",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "access_rear",
                table: "JobHeader",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "size_of_barriers_required",
                table: "JobHeader",
                newName: "udi_estrem");

            migrationBuilder.RenameColumn(
                name: "excess_ammount_str",
                table: "JobHeader",
                newName: "rexcedit");

            migrationBuilder.AlterColumn<int>(
                name: "work_on_public_footpath",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "work_at_height",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "shop_front_work",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "parking_at_rear",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "obs_wires",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "no_ladders",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "loose_brick",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "lintel_present",
                table: "JobHeader",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "items_above_roof",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "easy_park",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "bWorkInside",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "asbestos_visible",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "access_rear",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COD_Code",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SSRequired",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "bInfoSeen",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bcodchanged",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "f1_or_s2",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "f_add_txt",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "faddmuch",
                table: "JobHeader",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "faddpaid",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "fbunfinother",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "fexcess",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "fexcessoth",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "fitter_info_done",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "fjobfin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "fmand",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "fmandoth",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fmclrf",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fmdate",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fpartreq",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "freuntxt",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "funfincode",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "height_res",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_halifax",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "is_messagetoinsurer",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "issue_no",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ladder_req",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "messagetoinsurer",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "new_ispare1",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "new_ispare2",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "new_sspare9",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "parttxt",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "r_bcomp",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "r_comp",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "r_excess",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "r_sigimage",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "r_sign_date",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rcodchanged",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "refmessage",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "remedial_number",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "truecomm",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "truecommconf",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
