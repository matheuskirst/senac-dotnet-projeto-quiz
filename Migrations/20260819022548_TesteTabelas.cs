using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class TesteTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_QuizzesHistorico_QuizTentativaUsuarioI~",
                table: "PerguntasRespondidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_NiveisUsuarios_NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "NiveisUsuarios");

            migrationBuilder.DropTable(
                name: "QuizzesHistorico");

            migrationBuilder.DropTable(
                name: "QuizzesPerguntas");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas");

            migrationBuilder.DropIndex(
                name: "IX_PerguntasRespondidas_QuizTentativaUsuarioId_QuizTentativaQu~",
                table: "PerguntasRespondidas");

            migrationBuilder.DropColumn(
                name: "QuizTentativaId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropColumn(
                name: "QuizTentativaQuizId",
                table: "PerguntasRespondidas");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "NivelUsuarioId",
                table: "Usuarios",
                newName: "Nivel");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Nome",
                table: "Usuarios",
                newName: "IX_Usuarios_Username");

            migrationBuilder.RenameColumn(
                name: "QuizTentativaUsuarioId",
                table: "PerguntasRespondidas",
                newName: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas",
                columns: new[] { "UsuarioId", "PerguntaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Nivel",
                table: "Usuarios",
                newName: "NivelUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Username",
                table: "Usuarios",
                newName: "IX_Usuarios_Nome");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "PerguntasRespondidas",
                newName: "QuizTentativaUsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "QuizTentativaId",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuizTentativaQuizId",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaId", "PerguntaId" });

            migrationBuilder.CreateTable(
                name: "NiveisUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    PontosMax = table.Column<int>(type: "integer", nullable: false),
                    PontosMin = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveisUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataDeCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DataExibicao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    QuantidadePerguntas = table.Column<int>(type: "integer", nullable: false, defaultValue: 10)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesHistorico",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    Concluido = table.Column<bool>(type: "boolean", nullable: false),
                    DataFim = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoFinal = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzesHistorico", x => new { x.UsuarioId, x.QuizId });
                    table.ForeignKey(
                        name: "FK_QuizzesHistorico_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizzesHistorico_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesPerguntas",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzesPerguntas", x => new { x.QuizId, x.PerguntaId });
                    table.ForeignKey(
                        name: "FK_QuizzesPerguntas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizzesPerguntas_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NivelUsuarioId",
                table: "Usuarios",
                column: "NivelUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasRespondidas_QuizTentativaUsuarioId_QuizTentativaQu~",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaUsuarioId", "QuizTentativaQuizId" });

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesHistorico_QuizId",
                table: "QuizzesHistorico",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesPerguntas_PerguntaId",
                table: "QuizzesPerguntas",
                column: "PerguntaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_QuizzesHistorico_QuizTentativaUsuarioI~",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaUsuarioId", "QuizTentativaQuizId" },
                principalTable: "QuizzesHistorico",
                principalColumns: new[] { "UsuarioId", "QuizId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_NiveisUsuarios_NivelUsuarioId",
                table: "Usuarios",
                column: "NivelUsuarioId",
                principalTable: "NiveisUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
