using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculatorDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loggerinfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operationtime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculations");
        }
    }
}
