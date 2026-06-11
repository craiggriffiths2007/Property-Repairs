using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class garagedoormotor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gdm_cust_name",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_dec_made_by",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_door_manufacturer",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_door_size",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_door_type",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_model_type",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_operator_manufacturer",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_operator_type",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_powerered_operator_type",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_sign_date",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_site_address",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gdm_unique_serial",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gdm_cust_name",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_dec_made_by",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_door_manufacturer",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_door_size",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_door_type",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_model_type",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_operator_manufacturer",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_operator_type",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_powerered_operator_type",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_sign_date",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_site_address",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "gdm_unique_serial",
                table: "JobHeader");
        }
    }
}
