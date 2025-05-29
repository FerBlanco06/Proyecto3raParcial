using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto3raParcial.Migrations
{
    public partial class Uno_Muchos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Envios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Envios_ClienteId",
                table: "Envios",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Clientes_ClienteId",
                table: "Envios",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Clientes_ClienteId",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_ClienteId",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Envios");
        }
    }
}
