using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class tootlstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToolsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    files_a = table.Column<int>(type: "int", nullable: false),
                    pliers_a = table.Column<int>(type: "int", nullable: false),
                    chisels_a = table.Column<int>(type: "int", nullable: false),
                    pincers_a = table.Column<int>(type: "int", nullable: false),
                    scraper_a = table.Column<int>(type: "int", nullable: false),
                    hacksaw_a = table.Column<int>(type: "int", nullable: false),
                    crowbar_a = table.Column<int>(type: "int", nullable: false),
                    handsaw_a = table.Column<int>(type: "int", nullable: false),
                    molegrips_a = table.Column<int>(type: "int", nullable: false),
                    sidecutters_a = table.Column<int>(type: "int", nullable: false),
                    hammer_a = table.Column<int>(type: "int", nullable: false),
                    spiritlevel_a = table.Column<int>(type: "int", nullable: false),
                    screwdrivers_a = table.Column<int>(type: "int", nullable: false),
                    bolsterchisel_a = table.Column<int>(type: "int", nullable: false),
                    setsquare_a = table.Column<int>(type: "int", nullable: false),
                    stanleyknife_a = table.Column<int>(type: "int", nullable: false),
                    clubhammer_a = table.Column<int>(type: "int", nullable: false),
                    tapemeasure_a = table.Column<int>(type: "int", nullable: false),
                    slidingbevel_a = table.Column<int>(type: "int", nullable: false),
                    glazingshovel_a = table.Column<int>(type: "int", nullable: false),
                    pointingtrowel_a = table.Column<int>(type: "int", nullable: false),
                    setofallenkeys_a = table.Column<int>(type: "int", nullable: false),
                    adjustablespanner_a = table.Column<int>(type: "int", nullable: false),
                    augerbits_a = table.Column<int>(type: "int", nullable: false),
                    nailpunch_a = table.Column<int>(type: "int", nullable: false),
                    puttyknife_a = table.Column<int>(type: "int", nullable: false),
                    socketset_a = table.Column<int>(type: "int", nullable: false),
                    copingsaw_a = table.Column<int>(type: "int", nullable: false),
                    augerbitsjoin_a = table.Column<int>(type: "int", nullable: false),
                    nailpunchjoin_a = table.Column<int>(type: "int", nullable: false),
                    puttyknifejoin_a = table.Column<int>(type: "int", nullable: false),
                    socketsetjoin_a = table.Column<int>(type: "int", nullable: false),
                    copingsawjoin_a = table.Column<int>(type: "int", nullable: false),
                    rivetgunjoin_a = table.Column<int>(type: "int", nullable: false),
                    files_f = table.Column<int>(type: "int", nullable: false),
                    pliers_f = table.Column<int>(type: "int", nullable: false),
                    chisels_f = table.Column<int>(type: "int", nullable: false),
                    pincers_f = table.Column<int>(type: "int", nullable: false),
                    scraper_f = table.Column<int>(type: "int", nullable: false),
                    hacksaw_f = table.Column<int>(type: "int", nullable: false),
                    crowbar_f = table.Column<int>(type: "int", nullable: false),
                    handsaw_f = table.Column<int>(type: "int", nullable: false),
                    molegrips_f = table.Column<int>(type: "int", nullable: false),
                    sidecutters_f = table.Column<int>(type: "int", nullable: false),
                    hammer_f = table.Column<int>(type: "int", nullable: false),
                    spiritlevel_f = table.Column<int>(type: "int", nullable: false),
                    screwdrivers_f = table.Column<int>(type: "int", nullable: false),
                    bolsterchisel_f = table.Column<int>(type: "int", nullable: false),
                    setsquare_f = table.Column<int>(type: "int", nullable: false),
                    stanleyknife_f = table.Column<int>(type: "int", nullable: false),
                    clubhammer_f = table.Column<int>(type: "int", nullable: false),
                    tapemeasure_f = table.Column<int>(type: "int", nullable: false),
                    slidingbevel_f = table.Column<int>(type: "int", nullable: false),
                    glazingshovel_f = table.Column<int>(type: "int", nullable: false),
                    pointingtrowel_f = table.Column<int>(type: "int", nullable: false),
                    setofallenkeys_f = table.Column<int>(type: "int", nullable: false),
                    adjustablespanner_f = table.Column<int>(type: "int", nullable: false),
                    augerbits_f = table.Column<int>(type: "int", nullable: false),
                    nailpunch_f = table.Column<int>(type: "int", nullable: false),
                    puttyknife_f = table.Column<int>(type: "int", nullable: false),
                    socketset_f = table.Column<int>(type: "int", nullable: false),
                    copingsaw_f = table.Column<int>(type: "int", nullable: false),
                    augerbitsjoin_f = table.Column<int>(type: "int", nullable: false),
                    nailpunchjoin_f = table.Column<int>(type: "int", nullable: false),
                    puttyknifejoin_f = table.Column<int>(type: "int", nullable: false),
                    socketsetjoin_f = table.Column<int>(type: "int", nullable: false),
                    copingsawjoin_f = table.Column<int>(type: "int", nullable: false),
                    rivetgunjoin_f = table.Column<int>(type: "int", nullable: false),
                    date_done = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    bSigned = table.Column<bool>(type: "bit", nullable: false),
                    bSigned2 = table.Column<bool>(type: "bit", nullable: false),
                    signature_filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    signature_filename2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    signature_printed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    signature_printed2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo_filename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolsTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToolsTable");
        }
    }
}
