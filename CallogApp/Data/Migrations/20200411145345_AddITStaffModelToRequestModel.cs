using Microsoft.EntityFrameworkCore.Migrations;

namespace CallogApp.Data.Migrations
{
    public partial class AddITStaffModelToRequestModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResolvedBy",
                table: "Requests");

            migrationBuilder.AddColumn<int>(
                name: "ITStaffId",
                table: "Requests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ITStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Specialisation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITStaff", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ITStaffId",
                table: "Requests",
                column: "ITStaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_ITStaff_ITStaffId",
                table: "Requests",
                column: "ITStaffId",
                principalTable: "ITStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_ITStaff_ITStaffId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "ITStaff");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ITStaffId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ITStaffId",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "ResolvedBy",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
