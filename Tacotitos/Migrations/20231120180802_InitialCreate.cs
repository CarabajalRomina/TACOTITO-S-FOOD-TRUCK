using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tacotitos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BajaSino = table.Column<bool>(type: "bit", nullable: false),
                    CuandoSeElimino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeActualizo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "TiposIngredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadMax = table.Column<int>(type: "int", nullable: false),
                    BajaSino = table.Column<bool>(type: "bit", nullable: false),
                    CuandoSeElimino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeActualizo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIngredientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BajaSino = table.Column<bool>(type: "bit", nullable: false),
                    CuandoSeElimino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeActualizo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeCreo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    IdIngrediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    BajaSino = table.Column<bool>(type: "bit", nullable: false),
                    CuandoSeElimino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeActualizo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdTipoIngrediente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.IdIngrediente);
                    table.ForeignKey(
                        name: "FK_Ingredientes_TiposIngredientes_IdTipoIngrediente",
                        column: x => x.IdTipoIngrediente,
                        principalTable: "TiposIngredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tacos",
                columns: table => new
                {
                    IdTaco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BajaSino = table.Column<bool>(type: "bit", nullable: false),
                    CuandoSeElimino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeActualizo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeCreo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tacos", x => x.IdTaco);
                    table.ForeignKey(
                        name: "FK_Tacos_Pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesIngredientes",
                columns: table => new
                {
                    IdDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioUnitario = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BajaSino = table.Column<bool>(type: "bit", nullable: false),
                    CuandoSeElimino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeActualizo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuandoSeCreo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdIngrediente = table.Column<int>(type: "int", nullable: false),
                    IdTaco = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesIngredientes", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK_DetallesIngredientes_Ingredientes_IdIngrediente",
                        column: x => x.IdIngrediente,
                        principalTable: "Ingredientes",
                        principalColumn: "IdIngrediente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesIngredientes_Tacos_IdTaco",
                        column: x => x.IdTaco,
                        principalTable: "Tacos",
                        principalColumn: "IdTaco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngredientes_IdIngrediente",
                table: "DetallesIngredientes",
                column: "IdIngrediente");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngredientes_IdTaco",
                table: "DetallesIngredientes",
                column: "IdTaco");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_IdTipoIngrediente",
                table: "Ingredientes",
                column: "IdTipoIngrediente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdCliente",
                table: "Pedidos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Tacos_IdPedido",
                table: "Tacos",
                column: "IdPedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesIngredientes");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Tacos");

            migrationBuilder.DropTable(
                name: "TiposIngredientes");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
