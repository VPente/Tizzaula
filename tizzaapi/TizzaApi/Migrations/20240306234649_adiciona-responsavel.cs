using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TizzaApi.Migrations
{
    /// <inheritdoc />
    public partial class adicionaresponsavel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Responsavel",
                table: "Pizzaria",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "Pizzaria");
        }
    }
}
