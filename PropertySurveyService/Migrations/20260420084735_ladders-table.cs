using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class ladderstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaddersTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_done = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ladder_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fitter_surveyor_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    managers_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    in_reasonable_condition = table.Column<int>(type: "int", nullable: false),
                    rungs_missing_or_loose = table.Column<int>(type: "int", nullable: false),
                    stiles_damaged_or_bent = table.Column<int>(type: "int", nullable: false),
                    any_cracks = table.Column<int>(type: "int", nullable: false),
                    any_corrosion = table.Column<int>(type: "int", nullable: false),
                    rubber_plastic_feet = table.Column<int>(type: "int", nullable: false),
                    sharp_or_metal_splinters = table.Column<int>(type: "int", nullable: false),
                    rungs_dented = table.Column<int>(type: "int", nullable: false),
                    painted_or_decorated = table.Column<int>(type: "int", nullable: false),
                    hooks_sit_properly = table.Column<int>(type: "int", nullable: false),
                    ladders_been_repaired = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    bSigned = table.Column<bool>(type: "bit", nullable: false),
                    bSigned2 = table.Column<bool>(type: "bit", nullable: false),
                    signature_filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    any_damage = table.Column<int>(type: "int", nullable: false),
                    signature_filename_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ladder_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total_photos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaddersTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaddersTable");
        }
    }
}
