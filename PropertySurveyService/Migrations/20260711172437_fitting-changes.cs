using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class fittingchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bfitter_complete",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fbadditional_paid",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fbexcess_paid",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "fbmandate_signed",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "lintel_signed",
                table: "JobHeader",
                newName: "bFitterStockUsageComplete");

            migrationBuilder.RenameColumn(
                name: "isTowerScaff",
                table: "JobHeader",
                newName: "bFitterUsedTowerScaffolding");

            migrationBuilder.RenameColumn(
                name: "freason_mandate_not_signed",
                table: "JobHeader",
                newName: "FitterReasonMandateNotSigned");

            migrationBuilder.RenameColumn(
                name: "freason_excess_not_paid",
                table: "JobHeader",
                newName: "FitterReasonExcessNotPaid");

            migrationBuilder.RenameColumn(
                name: "fhow_mutch_additional_paid",
                table: "JobHeader",
                newName: "FitterAdditionalAmmount");

            migrationBuilder.RenameColumn(
                name: "fbstockusagecomplete",
                table: "JobHeader",
                newName: "bFitterSigned");

            migrationBuilder.RenameColumn(
                name: "bcompletion_signed",
                table: "JobHeader",
                newName: "bFitterLintelSigned");

            migrationBuilder.AddColumn<bool>(
                name: "bFitterAdditionalPaid",
                table: "JobHeader",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "bFitterCompletionFormComplete",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bFitterExcessPaid",
                table: "JobHeader",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "bFitterJobComplete",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bFitterMandateSigned",
                table: "JobHeader",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bFitterAdditionalPaid",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bFitterCompletionFormComplete",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bFitterExcessPaid",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bFitterJobComplete",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bFitterMandateSigned",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "bFitterUsedTowerScaffolding",
                table: "JobHeader",
                newName: "isTowerScaff");

            migrationBuilder.RenameColumn(
                name: "bFitterStockUsageComplete",
                table: "JobHeader",
                newName: "lintel_signed");

            migrationBuilder.RenameColumn(
                name: "bFitterSigned",
                table: "JobHeader",
                newName: "fbstockusagecomplete");

            migrationBuilder.RenameColumn(
                name: "bFitterLintelSigned",
                table: "JobHeader",
                newName: "bcompletion_signed");

            migrationBuilder.RenameColumn(
                name: "FitterReasonMandateNotSigned",
                table: "JobHeader",
                newName: "freason_mandate_not_signed");

            migrationBuilder.RenameColumn(
                name: "FitterReasonExcessNotPaid",
                table: "JobHeader",
                newName: "freason_excess_not_paid");

            migrationBuilder.RenameColumn(
                name: "FitterAdditionalAmmount",
                table: "JobHeader",
                newName: "fhow_mutch_additional_paid");

            migrationBuilder.AddColumn<int>(
                name: "bfitter_complete",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fbadditional_paid",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fbexcess_paid",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fbmandate_signed",
                table: "JobHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
