using Microsoft.EntityFrameworkCore.Migrations;

namespace Materiales.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCategoria = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoProveedor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedida",
                columns: table => new
                {
                    IdUnidadMedida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoUnidadMedida = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedida", x => x.IdUnidadMedida);
                });

            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    IdMaterial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoriaIdCategoria = table.Column<int>(type: "int", nullable: true),
                    ProveedorIdProveedor = table.Column<int>(type: "int", nullable: true),
                    UnidadMedidaIdUnidadMedida = table.Column<int>(type: "int", nullable: true),
                    Existencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.IdMaterial);
                    table.ForeignKey(
                        name: "FK_Materiales_Categoria_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materiales_Proveedor_ProveedorIdProveedor",
                        column: x => x.ProveedorIdProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materiales_UnidadMedida_UnidadMedidaIdUnidadMedida",
                        column: x => x.UnidadMedidaIdUnidadMedida,
                        principalTable: "UnidadMedida",
                        principalColumn: "IdUnidadMedida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_CategoriaIdCategoria",
                table: "Materiales",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_ProveedorIdProveedor",
                table: "Materiales",
                column: "ProveedorIdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_UnidadMedidaIdUnidadMedida",
                table: "Materiales",
                column: "UnidadMedidaIdUnidadMedida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "UnidadMedida");
        }
    }
}
