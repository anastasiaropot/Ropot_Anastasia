using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropot_Anastasia.Migrations
{
    public partial class dde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examen_Data_Examen_Data_ExID",
                table: "Examen");

            migrationBuilder.DropTable(
                name: "Data_Examen");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sala",
                table: "Examen",
                type: "decimal(3,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.CreateTable(
                name: "Data_Ex",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dati_de_examen = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data_Ex", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Examen_Data_Ex_Data_ExID",
                table: "Examen",
                column: "Data_ExID",
                principalTable: "Data_Ex",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examen_Data_Ex_Data_ExID",
                table: "Examen");

            migrationBuilder.DropTable(
                name: "Data_Ex");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sala",
                table: "Examen",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,0)");

            migrationBuilder.CreateTable(
                name: "Data_Examen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Ex = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data_Examen", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Examen_Data_Examen_Data_ExID",
                table: "Examen",
                column: "Data_ExID",
                principalTable: "Data_Examen",
                principalColumn: "ID");
        }
    }
}
