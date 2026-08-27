using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class OmegaAtualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestoes_Quizzes_QuizzesId",
                table: "QuizQuestoes");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Quizzes_QuizId",
                table: "UsuarioRespostas");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.RenameColumn(
                name: "IsCorreta",
                table: "Alternativas",
                newName: "Correta");

            migrationBuilder.CreateTable(
                name: "QuizzesDiarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamptz", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DataExibido = table.Column<DateOnly>(type: "date", nullable: false),
                    FoiConcluido = table.Column<bool>(type: "boolean", nullable: false),
                    DataConcluido = table.Column<DateTime>(type: "timestamptz", nullable: true),
                    TempoDeConclusao = table.Column<TimeSpan>(type: "interval", nullable: true),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzesDiarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzesDiarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesRush",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataIniciado = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataFinalizado = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TempoDeQuiz = table.Column<TimeSpan>(type: "interval", nullable: true),
                    QuantidadeAcertos = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false)
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
                name: "IX_QuizzesDiarios_UsuarioId_DataExibido",
                table: "QuizzesDiarios",
                columns: new[] { "UsuarioId", "DataExibido" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesRush_UsuarioId",
                table: "QuizzesRush",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestoes_QuizzesDiarios_QuizzesId",
                table: "QuizQuestoes",
                column: "QuizzesId",
                principalTable: "QuizzesDiarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_QuizzesDiarios_QuizId",
                table: "UsuarioRespostas",
                column: "QuizId",
                principalTable: "QuizzesDiarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestoes_QuizzesDiarios_QuizzesId",
                table: "QuizQuestoes");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_QuizzesDiarios_QuizId",
                table: "UsuarioRespostas");

            migrationBuilder.DropTable(
                name: "QuizzesDiarios");

            migrationBuilder.DropTable(
                name: "QuizzesRush");

            migrationBuilder.RenameColumn(
                name: "Correta",
                table: "Alternativas",
                newName: "IsCorreta");

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataConcluido = table.Column<DateTime>(type: "timestamptz", nullable: true),
                    DataExibido = table.Column<DateOnly>(type: "date", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamptz", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    FoiConcluido = table.Column<bool>(type: "boolean", nullable: false),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false),
                    TempoDeConclusao = table.Column<TimeSpan>(type: "interval", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UsuarioId_DataExibido",
                table: "Quizzes",
                columns: new[] { "UsuarioId", "DataExibido" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestoes_Quizzes_QuizzesId",
                table: "QuizQuestoes",
                column: "QuizzesId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Quizzes_QuizId",
                table: "UsuarioRespostas",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
