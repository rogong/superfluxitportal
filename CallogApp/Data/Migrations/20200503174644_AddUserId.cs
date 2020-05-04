using Microsoft.EntityFrameworkCore.Migrations;

namespace CallogApp.Data.Migrations
{
    public partial class AddUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Approvals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Approvals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_ApplicationUserId",
                table: "Approvals",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_AspNetUsers_ApplicationUserId",
                table: "Approvals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_AspNetUsers_ApplicationUserId",
                table: "Approvals");

            migrationBuilder.DropIndex(
                name: "IX_Approvals_ApplicationUserId",
                table: "Approvals");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Approvals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Approvals");
        }
    }
}
