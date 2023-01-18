using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropot_Anastasia.Migrations
{
    public partial class prof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.RenameColumn(
                name: "Data_ExID",
                table: "Examen",
                newName: "ProfesorCursID");          

            migrationBuilder.CreateTable(
                name: "ProfesorCurs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_ProfesorCurs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesorCurs", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Examen_ProfesorCurs_ProfesorCursID",
                table: "Examen",
                column: "ProfesorCursID",
                principalTable: "ProfesorCurs",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examen_ProfesorCurs_ProfesorCursID",
                table: "Examen");

            migrationBuilder.DropTable(
                name: "ProfesorCurs");

            migrationBuilder.RenameColumn(
                name: "ProfesorCursID",
                table: "Examen",
                newName: "Data_ExID");

            migrationBuilder.RenameIndex(
                name: "IX_Examen_ProfesorCursID",
                table: "Examen",
                newName: "IX_Examen_Data_ExID");

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
    }
}
