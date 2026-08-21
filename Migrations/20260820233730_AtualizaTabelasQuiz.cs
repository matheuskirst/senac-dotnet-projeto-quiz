using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaTabelasQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropTable(
                name: "PerguntasAlternativas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas");

            migrationBuilder.RenameColumn(
                name: "AcertosConsecutivos",
                table: "Usuarios",
                newName: "AtualAcertosConsecutivos");

            migrationBuilder.AlterColumn<int>(
                name: "Bonus",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizId", "PerguntaId" });

            migrationBuilder.CreateTable(
                name: "Alternativas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Texto = table.Column<string>(type: "text", nullable: false),
                    IsCorreta = table.Column<bool>(type: "boolean", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alternativas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DataDeConclusao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TempoDeConclusao = table.Column<TimeSpan>(type: "interval", nullable: true),
                    IsConcluido = table.Column<bool>(type: "boolean", nullable: false),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "QuizPerguntas",
                columns: table => new
                {
                    PerguntasId = table.Column<int>(type: "integer", nullable: false),
                    QuizzesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizPerguntas", x => new { x.PerguntasId, x.QuizzesId });
                    table.ForeignKey(
                        name: "FK_QuizPerguntas_Perguntas_PerguntasId",
                        column: x => x.PerguntasId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizPerguntas_Quizzes_QuizzesId",
                        column: x => x.QuizzesId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasRespondidas_UsuarioId",
                table: "PerguntasRespondidas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Alternativas_PerguntaId",
                table: "Alternativas",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizPerguntas_QuizzesId",
                table: "QuizPerguntas",
                column: "QuizzesId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UsuarioId",
                table: "Quizzes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_Quizzes_QuizId",
                table: "PerguntasRespondidas",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_Quizzes_QuizId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropTable(
                name: "Alternativas");

            migrationBuilder.DropTable(
                name: "QuizPerguntas");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas");

            migrationBuilder.DropIndex(
                name: "IX_PerguntasRespondidas_UsuarioId",
                table: "PerguntasRespondidas");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "PerguntasRespondidas");

            migrationBuilder.RenameColumn(
                name: "AtualAcertosConsecutivos",
                table: "Usuarios",
                newName: "AcertosConsecutivos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "PerguntasRespondidas",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasRespondidas",
                table: "PerguntasRespondidas",
                columns: new[] { "UsuarioId", "PerguntaId" });

            migrationBuilder.CreateTable(
                name: "PerguntasAlternativas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    IsCorreta = table.Column<bool>(type: "boolean", nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntasAlternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerguntasAlternativas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasAlternativas_PerguntaId",
                table: "PerguntasAlternativas",
                column: "PerguntaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                table: "PerguntasRespondidas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
