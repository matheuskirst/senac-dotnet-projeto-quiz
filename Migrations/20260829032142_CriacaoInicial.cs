using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestaoNiveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Valor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoNiveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoTemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                name: "UsuarioNiveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    PontosMin = table.Column<int>(type: "integer", nullable: false),
                    PontosMax = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioNiveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Nickname = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    DataDeNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Senha = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DataDeCadastro = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conquistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    Meta = table.Column<int>(type: "integer", nullable: true),
                    TemaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conquistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conquistas_QuestaoTemas_TemaId",
                        column: x => x.TemaId,
                        principalTable: "QuestaoTemas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TemaId = table.Column<int>(type: "integer", nullable: false),
                    NivelId = table.Column<int>(type: "integer", nullable: false),
                    TipoId = table.Column<int>(type: "integer", nullable: false),
                    Enunciado = table.Column<string>(type: "character varying(800)", maxLength: 800, nullable: false),
                    VerdadeiroFalso = table.Column<bool>(type: "boolean", nullable: true)
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
                name: "Acessos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataAcesso = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessos", x => new { x.UsuarioId, x.DataAcesso });
                    table.ForeignKey(
                        name: "FK_Acessos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizzesDiarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataExibido = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    DataIniciado = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Concluido = table.Column<bool>(type: "boolean", nullable: false),
                    DataConcluido = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
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
                    DataIniciado = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DataFinalizado = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Tempo = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Streak = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UsuarioStats",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    NivelId = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false),
                    TotalRespondidos = table.Column<int>(type: "integer", nullable: false),
                    TotalAcertos = table.Column<int>(type: "integer", nullable: false),
                    AtualAcertosSeguidos = table.Column<int>(type: "integer", nullable: false),
                    MaxAcertosSeguidos = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioStats", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_UsuarioStats_UsuarioNiveis_NivelId",
                        column: x => x.NivelId,
                        principalTable: "UsuarioNiveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioStats_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTemasProgressos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    TemaId = table.Column<int>(type: "integer", nullable: false),
                    RespostasCorretas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTemasProgressos", x => new { x.UsuarioId, x.TemaId });
                    table.ForeignKey(
                        name: "FK_UsuarioTemasProgressos_QuestaoTemas_TemaId",
                        column: x => x.TemaId,
                        principalTable: "QuestaoTemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioTemasProgressos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioConquistas",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    ConquistaId = table.Column<int>(type: "integer", nullable: false),
                    DataDeAquisicao = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioConquistas", x => new { x.UsuarioId, x.ConquistaId });
                    table.ForeignKey(
                        name: "FK_UsuarioConquistas_Conquistas_ConquistaId",
                        column: x => x.ConquistaId,
                        principalTable: "Conquistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioConquistas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alternativas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestaoId = table.Column<int>(type: "integer", nullable: false),
                    Texto = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    EhCorreta = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alternativas_Questoes_QuestaoId",
                        column: x => x.QuestaoId,
                        principalTable: "Questoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_QuizQuestoes_QuizzesDiarios_QuizzesId",
                        column: x => x.QuizzesId,
                        principalTable: "QuizzesDiarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRespostas",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    QuestaoId = table.Column<int>(type: "integer", nullable: false),
                    Acertou = table.Column<bool>(type: "boolean", nullable: false),
                    QuestaoValor = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoFinal = table.Column<int>(type: "integer", nullable: false),
                    DataDeResposta = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRespostas", x => new { x.UsuarioId, x.QuizId, x.QuestaoId });
                    table.ForeignKey(
                        name: "FK_UsuarioRespostas_Questoes_QuestaoId",
                        column: x => x.QuestaoId,
                        principalTable: "Questoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioRespostas_QuizzesDiarios_QuizId",
                        column: x => x.QuizId,
                        principalTable: "QuizzesDiarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alternativas_QuestaoId",
                table: "Alternativas",
                column: "QuestaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Conquistas_TemaId",
                table: "Conquistas",
                column: "TemaId");

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

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesDiarios_UsuarioId_DataExibido",
                table: "QuizzesDiarios",
                columns: new[] { "UsuarioId", "DataExibido" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesRush_UsuarioId",
                table: "QuizzesRush",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioConquistas_ConquistaId",
                table: "UsuarioConquistas",
                column: "ConquistaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRespostas_QuestaoId",
                table: "UsuarioRespostas",
                column: "QuestaoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRespostas_QuizId",
                table: "UsuarioRespostas",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Username",
                table: "Usuarios",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioStats_NivelId",
                table: "UsuarioStats",
                column: "NivelId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioTemasProgressos_TemaId",
                table: "UsuarioTemasProgressos",
                column: "TemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acessos");

            migrationBuilder.DropTable(
                name: "Alternativas");

            migrationBuilder.DropTable(
                name: "QuizQuestoes");

            migrationBuilder.DropTable(
                name: "QuizzesRush");

            migrationBuilder.DropTable(
                name: "UsuarioConquistas");

            migrationBuilder.DropTable(
                name: "UsuarioRespostas");

            migrationBuilder.DropTable(
                name: "UsuarioStats");

            migrationBuilder.DropTable(
                name: "UsuarioTemasProgressos");

            migrationBuilder.DropTable(
                name: "Conquistas");

            migrationBuilder.DropTable(
                name: "Questoes");

            migrationBuilder.DropTable(
                name: "QuizzesDiarios");

            migrationBuilder.DropTable(
                name: "UsuarioNiveis");

            migrationBuilder.DropTable(
                name: "QuestaoNiveis");

            migrationBuilder.DropTable(
                name: "QuestaoTemas");

            migrationBuilder.DropTable(
                name: "QuestaoTipos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
