using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class latchnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "l_itype1",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_itype2",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_itype3",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_itype4",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_itype5",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_itype6",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_itype7",
                table: "Lockmech");

            migrationBuilder.AddColumn<string>(
                name: "l_type1",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_type2",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_type3",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_type4",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_type5",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_type6",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "l_type7",
                table: "Lockmech",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "l_type1",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_type2",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_type3",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_type4",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_type5",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_type6",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "l_type7",
                table: "Lockmech");

            migrationBuilder.AddColumn<int>(
                name: "l_itype1",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype2",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype3",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype4",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype5",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype6",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "l_itype7",
                table: "Lockmech",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
