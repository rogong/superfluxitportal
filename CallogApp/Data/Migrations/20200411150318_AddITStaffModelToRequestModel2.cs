using Microsoft.EntityFrameworkCore.Migrations;

namespace CallogApp.Data.Migrations
{
    public partial class AddITStaffModelToRequestModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_ITStaff_ITStaffId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITStaff",
                table: "ITStaff");

            migrationBuilder.RenameTable(
                name: "ITStaff",
                newName: "ITStaffs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITStaffs",
                table: "ITStaffs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_ITStaffs_ITStaffId",
                table: "Requests",
                column: "ITStaffId",
                principalTable: "ITStaffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_ITStaffs_ITStaffId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITStaffs",
                table: "ITStaffs");

            migrationBuilder.RenameTable(
                name: "ITStaffs",
                newName: "ITStaff");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITStaff",
                table: "ITStaff",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_ITStaff_ITStaffId",
                table: "Requests",
                column: "ITStaffId",
                principalTable: "ITStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
