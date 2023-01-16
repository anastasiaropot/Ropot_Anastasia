﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropot_Anastasia.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Materie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sala = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examen", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examen");
        }
    }
}
