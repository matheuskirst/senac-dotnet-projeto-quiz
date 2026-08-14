using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTabelaPerguntasRespondidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerguntasRespondidas",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    PerguntaRespondidaId = table.Column<int>(type: "integer", nullable: false),
                    Acertou = table.Column<bool>(type: "boolean", nullable: false),
                    DataDeResposta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntasRespondidas", x => new { x.UsuarioId, x.PerguntaId });
                    table.ForeignKey(
                        name: "FK_PerguntasRespondidas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "PerguntaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasRespondidas_PerguntaId",
                table: "PerguntasRespondidas",
                column: "PerguntaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerguntasRespondidas");
        }
    }
}
