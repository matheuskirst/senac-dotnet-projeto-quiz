using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaQuizzes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizzesRush");

            migrationBuilder.DropColumn(
                name: "AtualAcertosSeguidos",
                table: "UsuarioStats");

            migrationBuilder.DropColumn(
                name: "MaxAcertosSeguidos",
                table: "UsuarioStats");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso")
                .OldAnnotation("Npgsql:Enum:Motivo Encerrado", "resposta_errada,tempo_esgotou")
                .OldAnnotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso");

            migrationBuilder.CreateTable(
                name: "RushHistoricos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    RecordeAntigo = table.Column<int>(type: "integer", nullable: false),
                    RecordeNovo = table.Column<int>(type: "integer", nullable: false),
                    DataRecordeBatido = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RushHistoricos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RushHistoricos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioDiarioRecordes",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    TotalAcertosDiarios = table.Column<int>(type: "integer", nullable: false),
                    AtualAcertosSeguidos = table.Column<int>(type: "integer", nullable: false),
                    MaxAcertosSeguidos = table.Column<int>(type: "integer", nullable: false),
                    PontosDiarios = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDiarioRecordes", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_UsuarioDiarioRecordes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRushRecordes",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    MaxStreak = table.Column<int>(type: "integer", nullable: false),
                    Tempo = table.Column<TimeSpan>(type: "interval", nullable: false),
                    DataRecorde = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRushRecordes", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_UsuarioRushRecordes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RushHistoricos_UsuarioId",
                table: "RushHistoricos",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RushHistoricos");

            migrationBuilder.DropTable(
                name: "UsuarioDiarioRecordes");

            migrationBuilder.DropTable(
                name: "UsuarioRushRecordes");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:Motivo Encerrado", "resposta_errada,tempo_esgotou")
                .Annotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso")
                .OldAnnotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso");

            migrationBuilder.AddColumn<int>(
                name: "AtualAcertosSeguidos",
                table: "UsuarioStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxAcertosSeguidos",
                table: "UsuarioStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "QuizzesRush",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataConcluido = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    DataIniciado = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    MotivoEncerrado = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false),
                    Streak = table.Column<int>(type: "integer", nullable: false),
                    Tempo = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzesRush", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzesRush_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesRush_UsuarioId_DataIniciado",
                table: "QuizzesRush",
                columns: new[] { "UsuarioId", "DataIniciado" },
                unique: true);
        }
    }
}
