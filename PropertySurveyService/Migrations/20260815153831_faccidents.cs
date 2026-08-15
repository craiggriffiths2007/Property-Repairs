using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class faccidents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "num_of_photographs",
                table: "FAccidents");

            migrationBuilder.DropColumn(
                name: "person_signed",
                table: "FAccidents");

            migrationBuilder.RenameColumn(
                name: "supervisor_signed",
                table: "FAccidents",
                newName: "no_of_photos");

            migrationBuilder.RenameColumn(
                name: "sign_date",
                table: "FAccidents",
                newName: "where_it_happened");

            migrationBuilder.RenameColumn(
                name: "filer_sign_date",
                table: "FAccidents",
                newName: "injuries_sustained");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_time",
                table: "FAccidents",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "where_it_happened",
                table: "FAccidents",
                newName: "sign_date");

            migrationBuilder.RenameColumn(
                name: "no_of_photos",
                table: "FAccidents",
                newName: "supervisor_signed");

            migrationBuilder.RenameColumn(
                name: "injuries_sustained",
                table: "FAccidents",
                newName: "filer_sign_date");

            migrationBuilder.AlterColumn<string>(
                name: "date_time",
                table: "FAccidents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "num_of_photographs",
                table: "FAccidents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "person_signed",
                table: "FAccidents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
