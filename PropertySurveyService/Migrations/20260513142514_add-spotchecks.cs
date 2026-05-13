using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class addspotchecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpotCheckTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    date_done = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    bCorrectContract = table.Column<bool>(type: "bit", nullable: false),
                    udi_cont = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Add1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Add2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Add3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_qualityofworks = table.Column<int>(type: "int", nullable: false),
                    uspot_appearence_improvements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_qualityofworks_improvements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_customersatisfaction_improvements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_otherobservations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_fitter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_trainee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_insuranceco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_customersatisfaction = table.Column<int>(type: "int", nullable: false),
                    uspot_customersatisfaction_improvementsOld = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_otherobservationsOld = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_signed = table.Column<bool>(type: "bit", nullable: false),
                    uspot_signeddate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uspot_replace_fit = table.Column<bool>(type: "bit", nullable: false),
                    uspot_p1 = table.Column<int>(type: "int", nullable: false),
                    uspot_p2 = table.Column<int>(type: "int", nullable: false),
                    uspot_p3 = table.Column<int>(type: "int", nullable: false),
                    uspot_p4 = table.Column<int>(type: "int", nullable: false),
                    uspot_repair = table.Column<bool>(type: "bit", nullable: false),
                    uspot_repair_arrived = table.Column<bool>(type: "bit", nullable: false),
                    uspot_repair_setup = table.Column<bool>(type: "bit", nullable: false),
                    uspot_repair_ongoing = table.Column<bool>(type: "bit", nullable: false),
                    uspot_repair_completed = table.Column<bool>(type: "bit", nullable: false),
                    uspot_replace = table.Column<bool>(type: "bit", nullable: false),
                    uspot_replace_arrived = table.Column<bool>(type: "bit", nullable: false),
                    uspot_replace_setup = table.Column<bool>(type: "bit", nullable: false),
                    uspot_replace_unitmoved = table.Column<bool>(type: "bit", nullable: false),
                    uspot_replace_completed = table.Column<bool>(type: "bit", nullable: false),
                    uspot_rev_door = table.Column<bool>(type: "bit", nullable: false),
                    uspot_rev_window = table.Column<bool>(type: "bit", nullable: false),
                    uspot_rev_garagedoor = table.Column<bool>(type: "bit", nullable: false),
                    uspot_rev_glass = table.Column<bool>(type: "bit", nullable: false),
                    uspot_rev_locks = table.Column<bool>(type: "bit", nullable: false),
                    uspot_rev_other = table.Column<bool>(type: "bit", nullable: false),
                    uspot_revb_upvc = table.Column<bool>(type: "bit", nullable: false),
                    uspot_revb_ali = table.Column<bool>(type: "bit", nullable: false),
                    uspot_revb_timber = table.Column<bool>(type: "bit", nullable: false),
                    uspot_revb_other = table.Column<bool>(type: "bit", nullable: false),
                    uspot_appearence = table.Column<int>(type: "int", nullable: false),
                    name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_boots_worn1 = table.Column<bool>(type: "bit", nullable: true),
                    safety_gloves_worn1 = table.Column<bool>(type: "bit", nullable: true),
                    safety_googles_worn1 = table.Column<bool>(type: "bit", nullable: true),
                    safety_helmet_worn1 = table.Column<bool>(type: "bit", nullable: true),
                    wristguards_worn1 = table.Column<bool>(type: "bit", nullable: true),
                    uniform_worn_complete1 = table.Column<bool>(type: "bit", nullable: true),
                    id_card_available1 = table.Column<bool>(type: "bit", nullable: true),
                    safety_boots_worn2 = table.Column<bool>(type: "bit", nullable: true),
                    safety_gloves_worn2 = table.Column<bool>(type: "bit", nullable: true),
                    safety_googles_worn2 = table.Column<bool>(type: "bit", nullable: true),
                    safety_helmet_worn2 = table.Column<bool>(type: "bit", nullable: true),
                    wristguards_worn2 = table.Column<bool>(type: "bit", nullable: true),
                    uniform_worn_complete2 = table.Column<bool>(type: "bit", nullable: true),
                    id_card_available2 = table.Column<bool>(type: "bit", nullable: true),
                    chemicals_stored_correctly = table.Column<bool>(type: "bit", nullable: true),
                    are_sheets_available = table.Column<bool>(type: "bit", nullable: true),
                    area_above_been_checked = table.Column<bool>(type: "bit", nullable: true),
                    obstructions_checked = table.Column<bool>(type: "bit", nullable: true),
                    lintel_ok = table.Column<bool>(type: "bit", nullable: true),
                    ladders_secure = table.Column<bool>(type: "bit", nullable: true),
                    safe_work_at_height = table.Column<bool>(type: "bit", nullable: true),
                    condition_of_ladders = table.Column<bool>(type: "bit", nullable: true),
                    tools_set_out_safely = table.Column<bool>(type: "bit", nullable: true),
                    fire_extinguisher_on_van = table.Column<bool>(type: "bit", nullable: true),
                    first_aid_kit_on_van = table.Column<bool>(type: "bit", nullable: true),
                    electrical_equipment_tested = table.Column<bool>(type: "bit", nullable: true),
                    safety_boots_worn1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_gloves_worn1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_googles_worn1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_helmet_worn1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wristguards_worn1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uniform_worn_complete1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_card_available1_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_boots_worn2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_gloves_worn2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_googles_worn2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safety_helmet_worn2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wristguards_worn2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uniform_worn_complete2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_card_available2_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chemicals_stored_correctly_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    are_sheets_available_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area_above_been_checked_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    obstructions_checked_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lintel_ok_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ladders_secure_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    safe_work_at_height_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    condition_of_ladders_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tools_set_out_safely_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fire_extinguisher_on_van_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_aid_kit_on_van_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    electrical_equipment_tested_s = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotCheckTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpotCheckTable");
        }
    }
}
