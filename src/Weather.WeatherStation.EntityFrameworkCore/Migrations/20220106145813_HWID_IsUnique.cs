using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.WeatherStation.Migrations
{
    public partial class HWID_IsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AppSensors_HWID",
                table: "AppSensors",
                column: "HWID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppDevices_HWID",
                table: "AppDevices",
                column: "HWID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppSensors_HWID",
                table: "AppSensors");

            migrationBuilder.DropIndex(
                name: "IX_AppDevices_HWID",
                table: "AppDevices");
        }
    }
}
