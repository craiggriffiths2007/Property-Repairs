using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class difforiginal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "UPVC",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Timber",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Panel",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Panel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Lockmech",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Greenhouse",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Glass",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Garage",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Conservatory",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Composite",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Composite",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Bifolding",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Aluminium",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "bDifferentFromOriginalSigned",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "UPVC");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Timber");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Panel");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Lockmech");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Greenhouse");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Glass");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Conservatory");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Composite");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Bifolding");

            migrationBuilder.DropColumn(
                name: "bDifferentFromOriginalSigned",
                table: "Aluminium");

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "UPVC",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Timber",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Panel",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Lockmech",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Greenhouse",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Glass",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Garage",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Conservatory",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Composite",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Bifolding",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bDifferentFromOriginal",
                table: "Aluminium",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
