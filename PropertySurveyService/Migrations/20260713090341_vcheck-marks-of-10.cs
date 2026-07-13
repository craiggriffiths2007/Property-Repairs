using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class vcheckmarksof10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "marks_out_of_10",
                table: "SalesCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "marks_out_of_10",
                table: "DeliveryVans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "marks_out_of_10",
                table: "DeliveryHGVs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "marks_out_of_10",
                table: "SalesCars");

            migrationBuilder.DropColumn(
                name: "marks_out_of_10",
                table: "DeliveryVans");

            migrationBuilder.DropColumn(
                name: "marks_out_of_10",
                table: "DeliveryHGVs");
        }
    }
}
