using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTabelasNovas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxAcertosConsecutivos",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NivelUsuarioId",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PontuacaoTotal",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAcertos",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRespondidos",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NivelPergunta",
                columns: table => new
                {
                    NivelPerguntaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Pontos = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelPergunta", x => x.NivelPerguntaId);
                });

            migrationBuilder.CreateTable(
                name: "NivelUsuario",
                columns: table => new
                {
                    NivelUsuarioId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    PontosMin = table.Column<int>(type: "integer", nullable: false),
                    PontosMax = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelUsuario", x => x.NivelUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "TemaPergunta",
                columns: table => new
                {
                    TemaPerguntaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemaPergunta", x => x.TemaPerguntaId);
                });

            migrationBuilder.CreateTable(
                name: "Perguntas",
                columns: table => new
                {
                    PerguntaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enunciado = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Respostas = table.Column<JsonDocument>(type: "jsonb", nullable: false),
                    NivelPerguntaId = table.Column<int>(type: "integer", nullable: false),
                    TemaPerguntaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perguntas", x => x.PerguntaId);
                    table.ForeignKey(
                        name: "FK_Perguntas_NivelPergunta_NivelPerguntaId",
                        column: x => x.NivelPerguntaId,
                        principalTable: "NivelPergunta",
                        principalColumn: "NivelPerguntaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perguntas_TemaPergunta_TemaPerguntaId",
                        column: x => x.TemaPerguntaId,
                        principalTable: "TemaPergunta",
                        principalColumn: "TemaPerguntaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NivelUsuarioId",
                table: "Usuarios",
                column: "NivelUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_NivelPerguntaId",
                table: "Perguntas",
                column: "NivelPerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_TemaPerguntaId",
                table: "Perguntas",
                column: "TemaPerguntaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_NivelUsuario_NivelUsuarioId",
                table: "Usuarios",
                column: "NivelUsuarioId",
                principalTable: "NivelUsuario",
                principalColumn: "NivelUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_NivelUsuario_NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "NivelUsuario");

            migrationBuilder.DropTable(
                name: "Perguntas");

            migrationBuilder.DropTable(
                name: "NivelPergunta");

            migrationBuilder.DropTable(
                name: "TemaPergunta");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "MaxAcertosConsecutivos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PontuacaoTotal",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TotalAcertos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TotalRespondidos",
                table: "Usuarios");
        }
    }
}
