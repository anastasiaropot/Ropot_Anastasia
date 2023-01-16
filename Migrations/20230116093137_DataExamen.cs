using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropot_Anastasia.Migrations
{
    public partial class DataExamen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Sala",
                table: "Examen",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExamen",
                table: "Examen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataExamen",
                table: "Examen");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sala",
                table: "Examen",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");
        }
    }
}
