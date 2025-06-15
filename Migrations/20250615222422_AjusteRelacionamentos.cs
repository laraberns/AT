using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AT.Migrations
{
    /// <inheritdoc />
    public partial class AjusteRelacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinos_PacotesTuristicos_PacoteTuristicoId",
                table: "Destinos");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Destinos_PacoteTuristicoId",
                table: "Destinos");

            migrationBuilder.DropColumn(
                name: "NumeroReservas",
                table: "PacotesTuristicos");

            migrationBuilder.DropColumn(
                name: "PacoteTuristicoId",
                table: "Destinos");

            migrationBuilder.CreateTable(
                name: "PacoteDestinos",
                columns: table => new
                {
                    PacoteTuristicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacoteDestinos", x => new { x.PacoteTuristicoId, x.DestinoId });
                    table.ForeignKey(
                        name: "FK_PacoteDestinos_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacoteDestinos_PacotesTuristicos_PacoteTuristicoId",
                        column: x => x.PacoteTuristicoId,
                        principalTable: "PacotesTuristicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteId_PacoteTuristicoId_DataReserva",
                table: "Reservas",
                columns: new[] { "ClienteId", "PacoteTuristicoId", "DataReserva" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PacoteDestinos_DestinoId",
                table: "PacoteDestinos",
                column: "DestinoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacoteDestinos");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ClienteId_PacoteTuristicoId_DataReserva",
                table: "Reservas");

            migrationBuilder.AddColumn<int>(
                name: "NumeroReservas",
                table: "PacotesTuristicos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacoteTuristicoId",
                table: "Destinos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinos_PacoteTuristicoId",
                table: "Destinos",
                column: "PacoteTuristicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinos_PacotesTuristicos_PacoteTuristicoId",
                table: "Destinos",
                column: "PacoteTuristicoId",
                principalTable: "PacotesTuristicos",
                principalColumn: "Id");
        }
    }
}
