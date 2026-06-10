using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class headercoppied : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "repudiation_completed",
                table: "JobHeader",
                newName: "photo_front_of_house");

            migrationBuilder.AddColumn<bool>(
                name: "bRepCom",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bRequestRepudiation",
                table: "JobHeader",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bRepCom",
                table: "JobHeader");

            migrationBuilder.DropColumn(
                name: "bRequestRepudiation",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "photo_front_of_house",
                table: "JobHeader",
                newName: "repudiation_completed");
        }
    }
}
