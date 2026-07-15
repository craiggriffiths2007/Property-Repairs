using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class jobheaderchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemedialCompleted",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bad_image_complete",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "faddimage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fit_no_of_videos",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fitter_videos",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fmanimage",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fsigimage",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "reason_excess_not_collected",
                table: "JobHeader",
                newName: "ReasonRemedialNotCompleted");

            migrationBuilder.RenameColumn(
                name: "photo_front_of_house",
                table: "JobHeader",
                newName: "bFitterAdditionalImage");

            migrationBuilder.RenameColumn(
                name: "no_of_photos",
                table: "JobHeader",
                newName: "no_of_front_house_photos");

            migrationBuilder.RenameColumn(
                name: "mop",
                table: "JobHeader",
                newName: "ReasonExcessNotCollected");

            migrationBuilder.RenameColumn(
                name: "funfinished_code",
                table: "JobHeader",
                newName: "MethodOfPayment");

            migrationBuilder.RenameColumn(
                name: "front_house_photos",
                table: "JobHeader",
                newName: "no_of_fitting_photos");

            migrationBuilder.RenameColumn(
                name: "freason_unfinished",
                table: "JobHeader",
                newName: "FitterUnfinishedCode");

            migrationBuilder.RenameColumn(
                name: "fparts_required",
                table: "JobHeader",
                newName: "FitterReasonJobNotCompleted");

            migrationBuilder.RenameColumn(
                name: "bAddSummaryInfo",
                table: "JobHeader",
                newName: "bRemedialCompleted");

            migrationBuilder.AddColumn<string>(
                name: "FitterPartsRequiredToComplete",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FitterPartsRequiredToComplete",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "no_of_front_house_photos",
                table: "JobHeader",
                newName: "no_of_photos");

            migrationBuilder.RenameColumn(
                name: "no_of_fitting_photos",
                table: "JobHeader",
                newName: "front_house_photos");

            migrationBuilder.RenameColumn(
                name: "bRemedialCompleted",
                table: "JobHeader",
                newName: "bAddSummaryInfo");

            migrationBuilder.RenameColumn(
                name: "bFitterAdditionalImage",
                table: "JobHeader",
                newName: "photo_front_of_house");

            migrationBuilder.RenameColumn(
                name: "ReasonRemedialNotCompleted",
                table: "JobHeader",
                newName: "reason_excess_not_collected");

            migrationBuilder.RenameColumn(
                name: "ReasonExcessNotCollected",
                table: "JobHeader",
                newName: "mop");

            migrationBuilder.RenameColumn(
                name: "MethodOfPayment",
                table: "JobHeader",
                newName: "funfinished_code");

            migrationBuilder.RenameColumn(
                name: "FitterUnfinishedCode",
                table: "JobHeader",
                newName: "freason_unfinished");

            migrationBuilder.RenameColumn(
                name: "FitterReasonJobNotCompleted",
                table: "JobHeader",
                newName: "fparts_required");

            migrationBuilder.AddColumn<bool>(
                name: "RemedialCompleted",
                table: "JobHeader",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "bad_image_complete",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "faddimage",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "fit_no_of_videos",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fitter_videos",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "fmanimage",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "fsigimage",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
