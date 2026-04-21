using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class addedguids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecID",
                table: "Header");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "VehicleCheckHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ToolsTable",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "MileageSheets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "LaddersTable",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Header",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "VehicleCheckHeaders");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ToolsTable");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "MileageSheets");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "LaddersTable");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Header");

            migrationBuilder.AddColumn<int>(
                name: "RecID",
                table: "Header",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
