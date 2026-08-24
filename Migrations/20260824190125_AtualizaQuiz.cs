using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Questoes_QuestaoId",
                table: "UsuarioRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Quizzes_QuizId",
                table: "UsuarioRespostas");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Questoes_QuestaoId",
                table: "UsuarioRespostas",
                column: "QuestaoId",
                principalTable: "Questoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Quizzes_QuizId",
                table: "UsuarioRespostas",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Questoes_QuestaoId",
                table: "UsuarioRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Quizzes_QuizId",
                table: "UsuarioRespostas");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Questoes_QuestaoId",
                table: "UsuarioRespostas",
                column: "QuestaoId",
                principalTable: "Questoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Quizzes_QuizId",
                table: "UsuarioRespostas",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
