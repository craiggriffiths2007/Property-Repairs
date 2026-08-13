using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class securitysurvey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bDamTicked",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bHazFin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bMOPFin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRepCom",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRepFin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bSRFin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bSSTicked",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bSubFin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bSumFin",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_alum",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_bifold",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_comp",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_cons",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_frames",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_garage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_glass",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_green",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_lock",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_panels",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_timber",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "incomplete_upvc",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_add_door_security",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_add_window_security",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_bIsComplete",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_bIsSecuritySurvey",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_gencondition",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_gencondition_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_location_doors_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_location_windows_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_lockdoors",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_lockdoors_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_lockwindows",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_lockwindows_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_matdoors",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_matdoors_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_matwindows",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_matwindows_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_no_of_photos",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_nodoors",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_nowindows",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_secdoors_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_secwindows_other",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "ss_time_required",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_alum",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_bifold",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_comp",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_cons",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_frames",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_garage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_glass",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_green",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_lock",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_panels",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_timber",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "total_upvc",
                table: "JobHeader");

            migrationBuilder.CreateTable(
                name: "SecuritySurveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    bIsSecuritySurvey = table.Column<int>(type: "int", nullable: false),
                    bIsComplete = table.Column<int>(type: "int", nullable: false),
                    nowindows = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nodoors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gencondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gencondition_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matwindows = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matwindows_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matdoors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matdoors_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lockwindows = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lockwindows_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lockdoors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lockdoors_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    add_window_security = table.Column<int>(type: "int", nullable: false),
                    location_windows_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secwindows_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    add_door_security = table.Column<int>(type: "int", nullable: false),
                    location_doors_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secdoors_other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_required = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    no_of_photos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecuritySurveys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecuritySurveys_JobHeader_Id",
                        column: x => x.Id,
                        principalTable: "JobHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecuritySurveys");

            migrationBuilder.AddColumn<bool>(
                name: "bDamTicked",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bHazFin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bMOPFin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRepCom",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRepFin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bSRFin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bSSTicked",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bSubFin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bSumFin",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_alum",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_bifold",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_comp",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_cons",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_frames",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_garage",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_glass",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_green",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_lock",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_panels",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_timber",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "incomplete_upvc",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ss_add_door_security",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ss_add_window_security",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ss_bIsComplete",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ss_bIsSecuritySurvey",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ss_gencondition",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_gencondition_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_location_doors_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_location_windows_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_lockdoors",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_lockdoors_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_lockwindows",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_lockwindows_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_matdoors",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_matdoors_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_matwindows",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_matwindows_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ss_no_of_photos",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ss_nodoors",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_nowindows",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_secdoors_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_secwindows_other",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ss_time_required",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "total_alum",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_bifold",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_comp",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_cons",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_frames",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_garage",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_glass",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_green",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_lock",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_panels",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_timber",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_upvc",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
