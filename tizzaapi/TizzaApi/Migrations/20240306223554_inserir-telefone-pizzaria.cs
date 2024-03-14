﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TizzaApi.Migrations
{
    /// <inheritdoc />
    public partial class inserirtelefonepizzaria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Pizzaria",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Pizzaria");
        }
    }
}
