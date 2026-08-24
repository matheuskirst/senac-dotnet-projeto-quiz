using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaTabelasQuestao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Perguntas_PerguntaId",
                table: "Alternativas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosRespostas_Perguntas_PerguntaId",
                table: "UsuariosRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                table: "UsuariosStatus");

            migrationBuilder.DropTable(
                name: "QuizPerguntas");

            migrationBuilder.DropTable(
                name: "Perguntas");

            migrationBuilder.DropTable(
                name: "PerguntaTemas");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosStatus_TemaMaisAcertadoId",
                table: "UsuariosStatus");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "UsuariosStatus");

            migrationBuilder.DropColumn(
                name: "TemaMaisAcertadoId",
                table: "UsuariosStatus");

            migrationBuilder.DropColumn(
                name: "TemaTotalAcertos",
                table: "UsuariosStatus");

            migrationBuilder.RenameColumn(
                name: "TemaTotalRespostas",
                table: "UsuariosStatus",
                newName: "NivelId");

            migrationBuilder.RenameColumn(
                name: "PerguntaId",
                table: "UsuariosRespostas",
                newName: "QuestaoId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosRespostas_PerguntaId",
                table: "UsuariosRespostas",
                newName: "IX_UsuariosRespostas_QuestaoId");

            migrationBuilder.RenameColumn(
                name: "PerguntaId",
                table: "Alternativas",
                newName: "QuestaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Alternativas_PerguntaId",
                table: "Alternativas",
                newName: "IX_Alternativas_QuestaoId");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Usuarios",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "Usuarios",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAquisicao",
                table: "UsuarioConquistas",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Conquistas",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Conquistas",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Conquistas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Alternativas",
                type: "character varying(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "QuestaoNiveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoNiveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoTemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoTemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoTipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoTipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioNivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioNivel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enunciado = table.Column<string>(type: "character varying(800)", maxLength: 800, nullable: false),
                    TemaId = table.Column<int>(type: "integer", nullable: false),
                    NivelId = table.Column<int>(type: "integer", nullable: false),
                    TipoId = table.Column<int>(type: "integer", nullable: false),
                    Verdadeira = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questoes_QuestaoNiveis_NivelId",
                        column: x => x.NivelId,
                        principalTable: "QuestaoNiveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questoes_QuestaoTemas_TemaId",
                        column: x => x.TemaId,
                        principalTable: "QuestaoTemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questoes_QuestaoTipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "QuestaoTipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestoes",
                columns: table => new
                {
                    QuestoesId = table.Column<int>(type: "integer", nullable: false),
                    QuizzesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestoes", x => new { x.QuestoesId, x.QuizzesId });
                    table.ForeignKey(
                        name: "FK_QuizQuestoes_Questoes_QuestoesId",
                        column: x => x.QuestoesId,
                        principalTable: "Questoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizQuestoes_Quizzes_QuizzesId",
                        column: x => x.QuizzesId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosStatus_NivelId",
                table: "UsuariosStatus",
                column: "NivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_NivelId",
                table: "Questoes",
                column: "NivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_TemaId",
                table: "Questoes",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_TipoId",
                table: "Questoes",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestoes_QuizzesId",
                table: "QuizQuestoes",
                column: "QuizzesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Questoes_QuestaoId",
                table: "Alternativas",
                column: "QuestaoId",
                principalTable: "Questoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosRespostas_Questoes_QuestaoId",
                table: "UsuariosRespostas",
                column: "QuestaoId",
                principalTable: "Questoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosStatus_UsuarioNivel_NivelId",
                table: "UsuariosStatus",
                column: "NivelId",
                principalTable: "UsuarioNivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Questoes_QuestaoId",
                table: "Alternativas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosRespostas_Questoes_QuestaoId",
                table: "UsuariosRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosStatus_UsuarioNivel_NivelId",
                table: "UsuariosStatus");

            migrationBuilder.DropTable(
                name: "QuizQuestoes");

            migrationBuilder.DropTable(
                name: "UsuarioNivel");

            migrationBuilder.DropTable(
                name: "Questoes");

            migrationBuilder.DropTable(
                name: "QuestaoNiveis");

            migrationBuilder.DropTable(
                name: "QuestaoTemas");

            migrationBuilder.DropTable(
                name: "QuestaoTipos");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosStatus_NivelId",
                table: "UsuariosStatus");

            migrationBuilder.RenameColumn(
                name: "NivelId",
                table: "UsuariosStatus",
                newName: "TemaTotalRespostas");

            migrationBuilder.RenameColumn(
                name: "QuestaoId",
                table: "UsuariosRespostas",
                newName: "PerguntaId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosRespostas_QuestaoId",
                table: "UsuariosRespostas",
                newName: "IX_UsuariosRespostas_PerguntaId");

            migrationBuilder.RenameColumn(
                name: "QuestaoId",
                table: "Alternativas",
                newName: "PerguntaId");

            migrationBuilder.RenameIndex(
                name: "IX_Alternativas_QuestaoId",
                table: "Alternativas",
                newName: "IX_Alternativas_PerguntaId");

            migrationBuilder.AddColumn<string>(
                name: "Nivel",
                table: "UsuariosStatus",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TemaMaisAcertadoId",
                table: "UsuariosStatus",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TemaTotalAcertos",
                table: "UsuariosStatus",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeAquisicao",
                table: "UsuarioConquistas",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Conquistas",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Conquistas",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Conquistas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Alternativas",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(400)",
                oldMaxLength: 400);

            migrationBuilder.CreateTable(
                name: "PerguntaTemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaTemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TemaId = table.Column<int>(type: "integer", nullable: false),
                    Enunciado = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Nivel = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perguntas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perguntas_PerguntaTemas_TemaId",
                        column: x => x.TemaId,
                        principalTable: "PerguntaTemas",
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
                name: "IX_UsuariosStatus_TemaMaisAcertadoId",
                table: "UsuariosStatus",
                column: "TemaMaisAcertadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_TemaId",
                table: "Perguntas",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizPerguntas_QuizzesId",
                table: "QuizPerguntas",
                column: "QuizzesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Perguntas_PerguntaId",
                table: "Alternativas",
                column: "PerguntaId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosRespostas_Perguntas_PerguntaId",
                table: "UsuariosRespostas",
                column: "PerguntaId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                table: "UsuariosStatus",
                column: "TemaMaisAcertadoId",
                principalTable: "PerguntaTemas",
                principalColumn: "Id");
        }
    }
}
