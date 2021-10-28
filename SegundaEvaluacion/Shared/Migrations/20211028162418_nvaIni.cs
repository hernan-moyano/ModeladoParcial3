using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundaEvaluacion.Shared.Migrations
{
    public partial class nvaIni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Paises_NacionalidadId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_NacionalidadId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NacionalidadId",
                table: "Personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NacionalidadId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NacionalidadId",
                table: "Personas",
                column: "NacionalidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Paises_NacionalidadId",
                table: "Personas",
                column: "NacionalidadId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
