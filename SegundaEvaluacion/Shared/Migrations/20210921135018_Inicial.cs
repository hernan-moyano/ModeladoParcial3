using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundaEvaluacion.Shared.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPais = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NombrePais = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NacionalidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Paises_NacionalidadId",
                        column: x => x.NacionalidadId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Pais_CodPais",
                table: "Paises",
                column: "CodPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NacionalidadId",
                table: "Personas",
                column: "NacionalidadId");

            migrationBuilder.CreateIndex(
                name: "UQ_Persona_dni",
                table: "Personas",
                column: "dni",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
