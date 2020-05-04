using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CallogApp.Data.Migrations
{
    public partial class ApprovalAndOthers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentModes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Currencies",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ApprovalLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApprovedStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovedStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requesters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Approvals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<int>(nullable: false),
                    RequesterId = table.Column<int>(nullable: false),
                    PaymentModeId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    LeagerName = table.Column<string>(nullable: true),
                    AnnualBudget = table.Column<double>(nullable: false),
                    YTD = table.Column<double>(nullable: false),
                    CurrentRequest = table.Column<double>(nullable: false),
                    YTDPercent = table.Column<double>(nullable: false),
                    Beneficiary = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    TotalCost = table.Column<double>(nullable: false),
                    AdvanceRequired = table.Column<string>(nullable: true),
                    PreparedBy = table.Column<string>(nullable: true),
                    CheckedBy = table.Column<string>(nullable: true),
                    AuthorisedBy = table.Column<string>(nullable: true),
                    ApprovedBy = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    ApprovalLevelId = table.Column<int>(nullable: false),
                    ApprovedStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approvals_ApprovalLevels_ApprovalLevelId",
                        column: x => x.ApprovalLevelId,
                        principalTable: "ApprovalLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_ApprovedStatuses_ApprovedStatusId",
                        column: x => x.ApprovedStatusId,
                        principalTable: "ApprovedStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_Requesters_RequesterId",
                        column: x => x.RequesterId,
                        principalTable: "Requesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_ApprovalLevelId",
                table: "Approvals",
                column: "ApprovalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_ApprovedStatusId",
                table: "Approvals",
                column: "ApprovedStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_CurrencyId",
                table: "Approvals",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_DepartmentId",
                table: "Approvals",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_PaymentModeId",
                table: "Approvals",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_RequesterId",
                table: "Approvals",
                column: "RequesterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Approvals");

            migrationBuilder.DropTable(
                name: "ApprovalLevels");

            migrationBuilder.DropTable(
                name: "ApprovedStatuses");

            migrationBuilder.DropTable(
                name: "Requesters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentModes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
