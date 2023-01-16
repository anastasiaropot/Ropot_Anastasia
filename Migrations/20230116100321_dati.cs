using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropot_Anastasia.Migrations
{
    public partial class dati : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Data_ExID",
                table: "Examen",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Examen_Data_ExID",
                table: "Examen",
                column: "Data_ExID");

            migrationBuilder.AddForeignKey(
                name: "FK_Examen_Data_Examen_Data_ExID",
                table: "Examen",
                column: "Data_ExID",
                principalTable: "Data_Examen",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examen_Data_Examen_Data_ExID",
                table: "Examen");

            migrationBuilder.DropTable(
                name: "Data_Examen");

            migrationBuilder.DropIndex(
                name: "IX_Examen_Data_ExID",
                table: "Examen");

            migrationBuilder.DropColumn(
                name: "Data_ExID",
                table: "Examen");
        }
    }
}
