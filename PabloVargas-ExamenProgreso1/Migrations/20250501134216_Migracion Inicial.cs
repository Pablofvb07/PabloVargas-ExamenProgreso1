
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PabloVargas_ExamenProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodigoSeguridad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstaAfiliado = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarifa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequiereMedicación = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamaño = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TieneVacunas = table.Column<bool>(type: "bit", nullable: false),
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascota_Propietario_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "Propietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_IdPropietario",
                table: "Mascota",
                column: "IdPropietario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Visita");

            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
