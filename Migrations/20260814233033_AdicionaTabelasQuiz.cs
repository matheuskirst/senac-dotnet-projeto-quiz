using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTabelasQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perguntas_NivelPergunta_NivelPerguntaId",
                table: "Perguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_Perguntas_TemaPergunta_TemaPerguntaId",
                table: "Perguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_NivelUsuario_NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemaPergunta",
                table: "TemaPergunta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NivelUsuario",
                table: "NivelUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NivelPergunta",
                table: "NivelPergunta");

            migrationBuilder.RenameTable(
                name: "TemaPergunta",
                newName: "TemasPerguntas");

            migrationBuilder.RenameTable(
                name: "NivelUsuario",
                newName: "NiveisUsuarios");

            migrationBuilder.RenameTable(
                name: "NivelPergunta",
                newName: "NiveisPerguntas");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UsuarioConquistaId",
                table: "UsuarioConquistas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PerguntaRespondidaId",
                table: "PerguntasRespondidas",
                newName: "QuizTentativaUsuarioId");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "PerguntasRespondidas",
                newName: "QuizTentativaQuizId");

            migrationBuilder.RenameColumn(
                name: "TemaPerguntaId",
                table: "Perguntas",
                newName: "TemaId");

            migrationBuilder.RenameColumn(
                name: "NivelPerguntaId",
                table: "Perguntas",
                newName: "NivelId");

            migrationBuilder.RenameColumn(
                name: "PerguntaId",
                table: "Perguntas",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Perguntas_TemaPerguntaId",
                table: "Perguntas",
                newName: "IX_Perguntas_TemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Perguntas_NivelPerguntaId",
                table: "Perguntas",
                newName: "IX_Perguntas_NivelId");

            migrationBuilder.RenameColumn(
                name: "ConquistaId",
                table: "Conquistas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TemaPerguntaId",
                table: "TemasPerguntas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NivelUsuarioId",
                table: "NiveisUsuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NivelPerguntaId",
                table: "NiveisPerguntas",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAquisicao",
                table: "UsuarioConquistas",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeResposta",
                table: "PerguntasRespondidas",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<int>(
                name: "QuizTentativaId",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pontuacao",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Respostas",
                table: "Perguntas",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(JsonDocument),
                oldType: "jsonb");

            migrationBuilder.AlterColumn<string>(
                name: "Enunciado",
                table: "Perguntas",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaId", "PerguntaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemasPerguntas",
                table: "TemasPerguntas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NiveisUsuarios",
                table: "NiveisUsuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NiveisPerguntas",
                table: "NiveisPerguntas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuantidadePerguntas = table.Column<int>(type: "integer", nullable: true, defaultValue: 10),
                    DataDeCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerguntaQuiz",
                columns: table => new
                {
                    PerguntasId = table.Column<int>(type: "integer", nullable: false),
                    QuizzesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaQuiz", x => new { x.PerguntasId, x.QuizzesId });
                    table.ForeignKey(
                        name: "FK_PerguntaQuiz_Perguntas_PerguntasId",
                        column: x => x.PerguntasId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerguntaQuiz_Quizzes_QuizzesId",
                        column: x => x.QuizzesId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesTentativas",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DataFim = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PontuacaoFinal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzesTentativas", x => new { x.UsuarioId, x.QuizId });
                    table.ForeignKey(
                        name: "FK_QuizzesTentativas_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizzesTentativas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasRespondidas_QuizTentativaUsuarioId_QuizTentativaQu~",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaUsuarioId", "QuizTentativaQuizId" });

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaQuiz_QuizzesId",
                table: "PerguntaQuiz",
                column: "QuizzesId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesTentativas_QuizId",
                table: "QuizzesTentativas",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perguntas_NiveisPerguntas_NivelId",
                table: "Perguntas",
                column: "NivelId",
                principalTable: "NiveisPerguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perguntas_TemasPerguntas_TemaId",
                table: "Perguntas",
                column: "TemaId",
                principalTable: "TemasPerguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_QuizzesTentativas_QuizTentativaUsuario~",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaUsuarioId", "QuizTentativaQuizId" },
                principalTable: "QuizzesTentativas",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perguntas_NiveisPerguntas_NivelId",
                table: "Perguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_Perguntas_TemasPerguntas_TemaId",
                table: "Perguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_QuizzesTentativas_QuizTentativaUsuario~",
                table: "PerguntasRespondidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_NiveisUsuarios_NivelUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "PerguntaQuiz");

            migrationBuilder.DropTable(
                name: "QuizzesTentativas");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas");

            migrationBuilder.DropIndex(
                name: "IX_PerguntasRespondidas_QuizTentativaUsuarioId_QuizTentativaQu~",
                table: "PerguntasRespondidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemasPerguntas",
                table: "TemasPerguntas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NiveisUsuarios",
                table: "NiveisUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NiveisPerguntas",
                table: "NiveisPerguntas");

            migrationBuilder.DropColumn(
                name: "QuizTentativaId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PerguntasRespondidas");

            migrationBuilder.DropColumn(
                name: "Pontuacao",
                table: "PerguntasRespondidas");

            migrationBuilder.RenameTable(
                name: "TemasPerguntas",
                newName: "TemaPergunta");

            migrationBuilder.RenameTable(
                name: "NiveisUsuarios",
                newName: "NivelUsuario");

            migrationBuilder.RenameTable(
                name: "NiveisPerguntas",
                newName: "NivelPergunta");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UsuarioConquistas",
                newName: "UsuarioConquistaId");

            migrationBuilder.RenameColumn(
                name: "QuizTentativaUsuarioId",
                table: "PerguntasRespondidas",
                newName: "PerguntaRespondidaId");

            migrationBuilder.RenameColumn(
                name: "QuizTentativaQuizId",
                table: "PerguntasRespondidas",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "TemaId",
                table: "Perguntas",
                newName: "TemaPerguntaId");

            migrationBuilder.RenameColumn(
                name: "NivelId",
                table: "Perguntas",
                newName: "NivelPerguntaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Perguntas",
                newName: "PerguntaId");

            migrationBuilder.RenameIndex(
                name: "IX_Perguntas_TemaId",
                table: "Perguntas",
                newName: "IX_Perguntas_TemaPerguntaId");

            migrationBuilder.RenameIndex(
                name: "IX_Perguntas_NivelId",
                table: "Perguntas",
                newName: "IX_Perguntas_NivelPerguntaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Conquistas",
                newName: "ConquistaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TemaPergunta",
                newName: "TemaPerguntaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NivelUsuario",
                newName: "NivelUsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NivelPergunta",
                newName: "NivelPerguntaId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAquisicao",
                table: "UsuarioConquistas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeResposta",
                table: "PerguntasRespondidas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<JsonDocument>(
                name: "Respostas",
                table: "Perguntas",
                type: "jsonb",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "jsonb",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Enunciado",
                table: "Perguntas",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas",
                columns: new[] { "UsuarioId", "PerguntaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemaPergunta",
                table: "TemaPergunta",
                column: "TemaPerguntaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NivelUsuario",
                table: "NivelUsuario",
                column: "NivelUsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NivelPergunta",
                table: "NivelPergunta",
                column: "NivelPerguntaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perguntas_NivelPergunta_NivelPerguntaId",
                table: "Perguntas",
                column: "NivelPerguntaId",
                principalTable: "NivelPergunta",
                principalColumn: "NivelPerguntaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perguntas_TemaPergunta_TemaPerguntaId",
                table: "Perguntas",
                column: "TemaPerguntaId",
                principalTable: "TemaPergunta",
                principalColumn: "TemaPerguntaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_NivelUsuario_NivelUsuarioId",
                table: "Usuarios",
                column: "NivelUsuarioId",
                principalTable: "NivelUsuario",
                principalColumn: "NivelUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
