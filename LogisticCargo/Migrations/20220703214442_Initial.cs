using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticCargo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DriverTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenseTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<int>(type: "int", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engine = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    LicenseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => new { x.DriverId, x.LicenseId });
                    table.ForeignKey(
                        name: "FK_Main_DriverTable_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriverTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Main_LicenseTable_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "LicenseTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Main_LicenseId",
                table: "Main",
                column: "LicenseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "DriverTable");

            migrationBuilder.DropTable(
                name: "LicenseTable");
        }
    }
}
