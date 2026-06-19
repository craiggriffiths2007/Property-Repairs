using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class datetimecompletedheader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FitDate",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "FitFinishTime",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "FitStartTime",
                table: "JobHeader");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCompleted",
                table: "JobHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeCompleted",
                table: "JobHeader");

            migrationBuilder.AddColumn<string>(
                name: "FitDate",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FitFinishTime",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FitStartTime",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
