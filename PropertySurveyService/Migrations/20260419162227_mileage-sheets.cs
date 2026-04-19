using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class mileagesheets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MileageSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sheet_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    finish_postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_mileage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    end_mileage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    end_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    no_of_other_places = table.Column<int>(type: "int", nullable: false),
                    time1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pcode1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pcode2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pcode3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bSigned = table.Column<bool>(type: "bit", nullable: false),
                    signature_filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtehrPlaceNo = table.Column<int>(type: "int", nullable: false),
                    op_time1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_time15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    op_postcode15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    toll_charges = table.Column<int>(type: "int", nullable: false),
                    toll_charge_for = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    toll_charge_ammount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo_am = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo_pm = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MileageSheets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MileageSheets");
        }
    }
}
