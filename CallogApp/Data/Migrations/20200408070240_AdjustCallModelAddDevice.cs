using Microsoft.EntityFrameworkCore.Migrations;

namespace CallogApp.Data.Migrations
{
    public partial class AdjustCallModelAddDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Issues_DeviceId",
                table: "Requests");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Devices_DeviceId",
                table: "Requests",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Devices_DeviceId",
                table: "Requests");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Issues_DeviceId",
                table: "Requests",
                column: "DeviceId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
