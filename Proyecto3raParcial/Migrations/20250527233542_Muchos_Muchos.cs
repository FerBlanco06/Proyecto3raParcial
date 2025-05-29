using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto3raParcial.Migrations
{
    /// <inheritdoc />
    public partial class Muchos_Muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Frutas_FrutaId",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_FrutaId",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "Cantidad_kg",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "Documentacion",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "Fecha_embarque",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "FrutaId",
                table: "Envios");

            migrationBuilder.RenameColumn(
                name: "Requisitos",
                table: "Clientes",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "Clientes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Nombre_empresa",
                table: "Clientes",
                newName: "Destino");

            migrationBuilder.RenameColumn(
                name: "Contacto",
                table: "Clientes",
                newName: "Correo");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroSerie",
                table: "Frutas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Frutas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "EnvioFruta",
                columns: table => new
                {
                    EnviosId = table.Column<int>(type: "int", nullable: false),
                    FrutasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvioFruta", x => new { x.EnviosId, x.FrutasId });
                    table.ForeignKey(
                        name: "FK_EnvioFruta_Envios_EnviosId",
                        column: x => x.EnviosId,
                        principalTable: "Envios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnvioFruta_Frutas_FrutasId",
                        column: x => x.FrutasId,
                        principalTable: "Frutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnvioFruta_FrutasId",
                table: "EnvioFruta",
                column: "FrutasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnvioFruta");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Clientes",
                newName: "Requisitos");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Clientes",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "Destino",
                table: "Clientes",
                newName: "Nombre_empresa");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Clientes",
                newName: "Contacto");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroSerie",
                table: "Frutas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Frutas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Cantidad_kg",
                table: "Envios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Documentacion",
                table: "Envios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_embarque",
                table: "Envios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FrutaId",
                table: "Envios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Envios_FrutaId",
                table: "Envios",
                column: "FrutaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Frutas_FrutaId",
                table: "Envios",
                column: "FrutaId",
                principalTable: "Frutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
