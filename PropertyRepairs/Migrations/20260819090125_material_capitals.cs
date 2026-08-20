using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyRepairs.Migrations
{
    /// <inheritdoc />
    public partial class material_capitals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "material",
                table: "Assembly",
                newName: "Material");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Material",
                table: "Assembly",
                newName: "material");
        }
    }
}
