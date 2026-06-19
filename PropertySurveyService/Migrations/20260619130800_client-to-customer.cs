using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class clienttocustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientAddPhoneNumber1",
                table: "JobHeader");

            migrationBuilder.RenameColumn(
                name: "CustomerNumber",
                table: "JobHeader",
                newName: "CustomerPostcode");

            migrationBuilder.RenameColumn(
                name: "ClientPostcode",
                table: "JobHeader",
                newName: "CustomerPhoneNumber3");

            migrationBuilder.RenameColumn(
                name: "ClientPhoneNumber3",
                table: "JobHeader",
                newName: "CustomerPhoneNumber2");

            migrationBuilder.RenameColumn(
                name: "ClientPhoneNumber2",
                table: "JobHeader",
                newName: "CustomerPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ClientPhoneNumber",
                table: "JobHeader",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "JobHeader",
                newName: "CustomerAddressLine4");

            migrationBuilder.RenameColumn(
                name: "ClientAddressLine4",
                table: "JobHeader",
                newName: "CustomerAddressLine3");

            migrationBuilder.RenameColumn(
                name: "ClientAddressLine3",
                table: "JobHeader",
                newName: "CustomerAddressLine2");

            migrationBuilder.RenameColumn(
                name: "ClientAddressLine2",
                table: "JobHeader",
                newName: "CustomerAddressLine1");

            migrationBuilder.RenameColumn(
                name: "ClientAddressLine1",
                table: "JobHeader",
                newName: "CustomerAddPhoneNumber2");

            migrationBuilder.RenameColumn(
                name: "ClientAddPhoneNumber2",
                table: "JobHeader",
                newName: "CustomerAddPhoneNumber1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerPostcode",
                table: "JobHeader",
                newName: "CustomerNumber");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber3",
                table: "JobHeader",
                newName: "ClientPostcode");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber2",
                table: "JobHeader",
                newName: "ClientPhoneNumber3");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber",
                table: "JobHeader",
                newName: "ClientPhoneNumber2");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "JobHeader",
                newName: "ClientPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "CustomerAddressLine4",
                table: "JobHeader",
                newName: "ClientName");

            migrationBuilder.RenameColumn(
                name: "CustomerAddressLine3",
                table: "JobHeader",
                newName: "ClientAddressLine4");

            migrationBuilder.RenameColumn(
                name: "CustomerAddressLine2",
                table: "JobHeader",
                newName: "ClientAddressLine3");

            migrationBuilder.RenameColumn(
                name: "CustomerAddressLine1",
                table: "JobHeader",
                newName: "ClientAddressLine2");

            migrationBuilder.RenameColumn(
                name: "CustomerAddPhoneNumber2",
                table: "JobHeader",
                newName: "ClientAddressLine1");

            migrationBuilder.RenameColumn(
                name: "CustomerAddPhoneNumber1",
                table: "JobHeader",
                newName: "ClientAddPhoneNumber2");

            migrationBuilder.AddColumn<string>(
                name: "ClientAddPhoneNumber1",
                table: "JobHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
