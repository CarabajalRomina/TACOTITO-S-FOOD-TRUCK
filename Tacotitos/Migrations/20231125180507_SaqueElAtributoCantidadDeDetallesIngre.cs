using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tacotitos.Migrations
{
    /// <inheritdoc />
    public partial class SaqueElAtributoCantidadDeDetallesIngre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "DetallesIngredientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "DetallesIngredientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
