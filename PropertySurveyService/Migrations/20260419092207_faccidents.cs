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
            migrationBuilder.CreateTable(
                name: "FAccidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    add1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    add2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    add3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_add1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_add2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_add3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_pcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sign_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filer_sign_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_happened = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_happened = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    how_did_accident_happen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    materials_used_in_treatment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    person_signed = table.Column<int>(type: "int", nullable: false),
                    supervisor_signed = table.Column<int>(type: "int", nullable: false),
                    num_of_photographs = table.Column<int>(type: "int", nullable: false),
                    sig_fname1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sig_fname2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    injuries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    where_happ_acc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    what_happened = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    where_abouts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anon_or_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAccidents", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAccidents");
        }
    }
}
