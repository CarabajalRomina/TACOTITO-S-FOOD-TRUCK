using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tacotitos.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CuandoSeCreo",
                table: "TiposIngredientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CuandoSeCreo",
                table: "Ingredientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuandoSeCreo",
                table: "TiposIngredientes");

            migrationBuilder.DropColumn(
                name: "CuandoSeCreo",
                table: "Ingredientes");
        }
    }
}
