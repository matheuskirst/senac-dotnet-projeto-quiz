using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTabelaUsuarioStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerguntasRespondidas");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_UsuarioId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "AtualAcertosConsecutivos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "MaxAcertosConsecutivos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nivel",
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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UsuarioConquistas");

            migrationBuilder.RenameColumn(
                name: "DataDeCriacao",
                table: "Quizzes",
                newName: "DataInicio");

            migrationBuilder.RenameColumn(
                name: "DataDeConclusao",
                table: "Quizzes",
                newName: "DataConcluido");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataExibido",
                table: "Quizzes",
                type: "date",
                nullable: false,
                defaultValueSql: "CURRENT_DATE");

            migrationBuilder.CreateTable(
                name: "UsuariosRespostas",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Acertou = table.Column<bool>(type: "boolean", nullable: false),
                    Bonus = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoFinal = table.Column<int>(type: "integer", nullable: false),
                    DataDeResposta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UsuarioId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosRespostas", x => new { x.QuizId, x.PerguntaId });
                    table.ForeignKey(
                        name: "FK_UsuariosRespostas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosRespostas_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosRespostas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsuariosStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nivel = table.Column<string>(type: "text", nullable: false),
                    PontuacaoTotal = table.Column<int>(type: "integer", nullable: false),
                    TotalRespondidos = table.Column<int>(type: "integer", nullable: false),
                    TotalAcertos = table.Column<int>(type: "integer", nullable: false),
                    AtualAcertosConsecutivos = table.Column<int>(type: "integer", nullable: false),
                    MaxAcertosConsecutivos = table.Column<int>(type: "integer", nullable: false),
                    TemaMaisAcertadoId = table.Column<int>(type: "integer", nullable: false),
                    TemaTotalRespostas = table.Column<int>(type: "integer", nullable: false),
                    TemaTotalAcertos = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                        column: x => x.TemaMaisAcertadoId,
                        principalTable: "PerguntaTemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosStatus_Usuarios_Id",
                        column: x => x.Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UsuarioId_DataExibido",
                table: "Quizzes",
                columns: new[] { "UsuarioId", "DataExibido" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosRespostas_PerguntaId",
                table: "UsuariosRespostas",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosRespostas_UsuarioId",
                table: "UsuariosRespostas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosStatus_TemaMaisAcertadoId",
                table: "UsuariosStatus",
                column: "TemaMaisAcertadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosRespostas");

            migrationBuilder.DropTable(
                name: "UsuariosStatus");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_UsuarioId_DataExibido",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "DataExibido",
                table: "Quizzes");

            migrationBuilder.RenameColumn(
                name: "DataInicio",
                table: "Quizzes",
                newName: "DataDeCriacao");

            migrationBuilder.RenameColumn(
                name: "DataConcluido",
                table: "Quizzes",
                newName: "DataDeConclusao");

            migrationBuilder.AddColumn<int>(
                name: "AtualAcertosConsecutivos",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxAcertosConsecutivos",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UsuarioConquistas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PerguntasRespondidas",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    Acertou = table.Column<bool>(type: "boolean", nullable: false),
                    Bonus = table.Column<int>(type: "integer", nullable: false),
                    DataDeResposta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    PontuacaoFinal = table.Column<int>(type: "integer", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntasRespondidas", x => new { x.QuizId, x.PerguntaId });
                    table.ForeignKey(
                        name: "FK_PerguntasRespondidas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerguntasRespondidas_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerguntasRespondidas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UsuarioId",
                table: "Quizzes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasRespondidas_PerguntaId",
                table: "PerguntasRespondidas",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasRespondidas_UsuarioId",
                table: "PerguntasRespondidas",
                column: "UsuarioId");
        }
    }
}
