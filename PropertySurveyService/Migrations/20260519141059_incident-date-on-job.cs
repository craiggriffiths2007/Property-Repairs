using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class incidentdateonjob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IncidentAdded",
                table: "Contract",
                newName: "IncidentDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "IncidentDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncidentDate",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "IncidentDate",
                table: "Contract",
                newName: "IncidentAdded");
        }
    }
}
