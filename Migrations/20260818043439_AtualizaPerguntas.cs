using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaPerguntas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "NiveisPerguntas");

            migrationBuilder.DropTable(
                name: "QuizzesTentativas");

            migrationBuilder.DropTable(
                name: "TemasPerguntas");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Nickname",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Perguntas_NivelId",
                table: "Perguntas");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Perguntas");

            migrationBuilder.AlterColumn<int>(
                name: "QuantidadePerguntas",
                table: "Quizzes",
                type: "integer",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "PerguntasRespondidas",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Nivel",
                table: "Perguntas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PerguntaTemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaTemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesHistorico",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DataFim = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Concluido = table.Column<bool>(type: "boolean", nullable: false),
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

            migrationBuilder.InsertData(
                table: "PerguntaTemas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Hardware" },
                    { 2, "Programação" },
                    { 3, "Redes" },
                    { 4, "Segurança Digital" },
                    { 5, "Sistemas Operacionais" },
                    { 6, "Ferramentas de Produtividade" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Nome",
                table: "Usuarios",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesHistorico_QuizId",
                table: "QuizzesHistorico",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perguntas_PerguntaTemas_TemaId",
                table: "Perguntas",
                column: "TemaId",
                principalTable: "PerguntaTemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasRespondidas_QuizzesHistorico_QuizTentativaUsuarioI~",
                table: "PerguntasRespondidas",
                columns: new[] { "QuizTentativaUsuarioId", "QuizTentativaQuizId" },
                principalTable: "QuizzesHistorico",
                principalColumns: new[] { "UsuarioId", "QuizId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perguntas_PerguntaTemas_TemaId",
                table: "Perguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasRespondidas_QuizzesHistorico_QuizTentativaUsuarioI~",
                table: "PerguntasRespondidas");

            migrationBuilder.DropTable(
                name: "PerguntaTemas");

            migrationBuilder.DropTable(
                name: "QuizzesHistorico");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Nome",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Perguntas");

            migrationBuilder.AlterColumn<int>(
                name: "QuantidadePerguntas",
                table: "Quizzes",
                type: "integer",
                nullable: true,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Bonus",
                table: "PerguntasRespondidas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Perguntas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NiveisPerguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Pontos = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveisPerguntas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesTentativas",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    Concluido = table.Column<bool>(type: "boolean", nullable: false),
                    DataFim = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Id = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "TemasPerguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemasPerguntas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Nickname",
                table: "Usuarios",
                column: "Nickname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_NivelId",
                table: "Perguntas",
                column: "NivelId");

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
        }
    }
}
