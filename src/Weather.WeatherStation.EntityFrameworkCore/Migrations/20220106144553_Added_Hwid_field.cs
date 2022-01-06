using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.WeatherStation.Migrations
{
    public partial class Added_Hwid_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HWID",
                table: "AppSensors",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HWID",
                table: "AppDevices",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HWID",
                table: "AppSensors");

            migrationBuilder.DropColumn(
                name: "HWID",
                table: "AppDevices");
        }
    }
}
