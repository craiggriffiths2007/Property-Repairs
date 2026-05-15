using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class removedspotchecksfromheader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bSpotCheck",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_appearence",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_appearence_improvements",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_branch",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_customer",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_customersatisfaction",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_customersatisfaction_improvements",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_customersatisfaction_improvementsOld",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_date",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_fitter",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_insuranceco",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_otherobservations",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_otherobservationsOld",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_p1",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_p2",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_p3",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_p4",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_postcode",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_qualityofworks_improvements",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_repair",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_repair_arrived",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_repair_completed",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_repair_ongoing",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_repair_setup",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_replace",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_replace_arrived",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_replace_completed",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_replace_fit",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_replace_setup",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_replace_unitmoved",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_rev_door",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_rev_garagedoor",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_rev_glass",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_rev_locks",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_rev_other",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_rev_window",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_revb_ali",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_revb_other",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_revb_timber",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_revb_upvc",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_signeddate",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "uspot_trainee",
                table: "Header");

            migrationBuilder.RenameColumn(
                name: "uspot_signed",
                table: "Header",
                newName: "lintel_signed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lintel_signed",
                table: "Header",
                newName: "uspot_signed");

            migrationBuilder.AddColumn<bool>(
                name: "bSpotCheck",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "uspot_appearence",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "uspot_appearence_improvements",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_branch",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_customer",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "uspot_customersatisfaction",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "uspot_customersatisfaction_improvements",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_customersatisfaction_improvementsOld",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_date",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_fitter",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_insuranceco",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_otherobservations",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_otherobservationsOld",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "uspot_p1",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "uspot_p2",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "uspot_p3",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "uspot_p4",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "uspot_postcode",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_qualityofworks_improvements",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "uspot_repair",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_repair_arrived",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_repair_completed",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_repair_ongoing",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_repair_setup",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_replace",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_replace_arrived",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_replace_completed",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_replace_fit",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_replace_setup",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_replace_unitmoved",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_rev_door",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_rev_garagedoor",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_rev_glass",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_rev_locks",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_rev_other",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_rev_window",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_revb_ali",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_revb_other",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_revb_timber",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "uspot_revb_upvc",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "uspot_signeddate",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uspot_trainee",
                table: "Header",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
