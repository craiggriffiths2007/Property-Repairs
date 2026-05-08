using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class renamedframestabletoitemstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FrameTable",
                table: "FrameTable");

            migrationBuilder.RenameTable(
                name: "FrameTable",
                newName: "ItemTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTable",
                table: "ItemTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTable",
                table: "ItemTable");

            migrationBuilder.RenameTable(
                name: "ItemTable",
                newName: "FrameTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FrameTable",
                table: "FrameTable",
                column: "Id");
        }
    }
}
