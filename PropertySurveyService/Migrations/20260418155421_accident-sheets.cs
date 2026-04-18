using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class accidentsheets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accident_sheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    brief = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_instructions = table.Column<bool>(type: "bit", nullable: false),
                    c_details = table.Column<bool>(type: "bit", nullable: false),
                    c_you = table.Column<bool>(type: "bit", nullable: false),
                    c_them = table.Column<bool>(type: "bit", nullable: false),
                    c_police = table.Column<bool>(type: "bit", nullable: false),
                    c_witness = table.Column<bool>(type: "bit", nullable: false),
                    c_photographs = table.Column<bool>(type: "bit", nullable: false),
                    c_drawings = table.Column<bool>(type: "bit", nullable: false),
                    d_bPolice = table.Column<bool>(type: "bit", nullable: false),
                    d_officers_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_officers_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_station = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_speed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_weather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    d_sign_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_reg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_used_for = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_driver_full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_driver_dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_address3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_pcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_years_employed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_months_employed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_any_other_accidents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_infirmity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_prosecution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_vehicle_damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_driveable = table.Column<int>(type: "int", nullable: false),
                    y_damage_to_property = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_injuries_sustained = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    y_signed = table.Column<bool>(type: "bit", nullable: false),
                    t_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_add1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_add2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_add3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_pcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_reg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_insurer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_policy_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t_telnum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    no_of_other_people = table.Column<int>(type: "int", nullable: false),
                    p_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_add1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_add2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_add3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_pcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_wittel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v_reg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v_model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acc_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acc_time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accident_sheets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Whitnesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccidentId = table.Column<int>(type: "int", nullable: false),
                    p_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_add1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_add2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_add3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_pcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_wittel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whitnesses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accident_sheets");

            migrationBuilder.DropTable(
                name: "Whitnesses");
        }
    }
}
