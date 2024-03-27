using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TizzaApi.Migrations
{
    /// <inheritdoc />
    public partial class agoraVai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataVigenciaPromover",
                table: "Pizzaria",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "ValorPromover",
                table: "Pizzaria",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Promover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataVigencia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoPizzaria = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promover", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promover_Pizzaria_CodigoPizzaria",
                        column: x => x.CodigoPizzaria,
                        principalTable: "Pizzaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promover_CodigoPizzaria",
                table: "Promover",
                column: "CodigoPizzaria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promover");

            migrationBuilder.DropColumn(
                name: "DataVigenciaPromover",
                table: "Pizzaria");

            migrationBuilder.DropColumn(
                name: "ValorPromover",
                table: "Pizzaria");
        }
    }
}
