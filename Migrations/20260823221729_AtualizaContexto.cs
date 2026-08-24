using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaContexto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosRespostas_Questoes_QuestaoId",
                table: "UsuariosRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosRespostas_Quizzes_QuizId",
                table: "UsuariosRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosRespostas_Usuarios_UsuarioId",
                table: "UsuariosRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosStatus_UsuarioNivel_NivelId",
                table: "UsuariosStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosStatus_Usuarios_Id",
                table: "UsuariosStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosStatus",
                table: "UsuariosStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosRespostas",
                table: "UsuariosRespostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioNivel",
                table: "UsuarioNivel");

            migrationBuilder.RenameTable(
                name: "UsuariosStatus",
                newName: "UsuarioStatus");

            migrationBuilder.RenameTable(
                name: "UsuariosRespostas",
                newName: "UsuarioRespostas");

            migrationBuilder.RenameTable(
                name: "UsuarioNivel",
                newName: "UsuarioNiveis");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosStatus_NivelId",
                table: "UsuarioStatus",
                newName: "IX_UsuarioStatus_NivelId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosRespostas_UsuarioId",
                table: "UsuarioRespostas",
                newName: "IX_UsuarioRespostas_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosRespostas_QuestaoId",
                table: "UsuarioRespostas",
                newName: "IX_UsuarioRespostas_QuestaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioStatus",
                table: "UsuarioStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioRespostas",
                table: "UsuarioRespostas",
                columns: new[] { "QuizId", "QuestaoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioNiveis",
                table: "UsuarioNiveis",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                table: "UsuarioRespostas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStatus_UsuarioNiveis_NivelId",
                table: "UsuarioStatus",
                column: "NivelId",
                principalTable: "UsuarioNiveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStatus_Usuarios_Id",
                table: "UsuarioStatus",
                column: "Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                table: "UsuarioRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStatus_UsuarioNiveis_NivelId",
                table: "UsuarioStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStatus_Usuarios_Id",
                table: "UsuarioStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioStatus",
                table: "UsuarioStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioRespostas",
                table: "UsuarioRespostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioNiveis",
                table: "UsuarioNiveis");

            migrationBuilder.RenameTable(
                name: "UsuarioStatus",
                newName: "UsuariosStatus");

            migrationBuilder.RenameTable(
                name: "UsuarioRespostas",
                newName: "UsuariosRespostas");

            migrationBuilder.RenameTable(
                name: "UsuarioNiveis",
                newName: "UsuarioNivel");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioStatus_NivelId",
                table: "UsuariosStatus",
                newName: "IX_UsuariosStatus_NivelId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioRespostas_UsuarioId",
                table: "UsuariosRespostas",
                newName: "IX_UsuariosRespostas_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioRespostas_QuestaoId",
                table: "UsuariosRespostas",
                newName: "IX_UsuariosRespostas_QuestaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosStatus",
                table: "UsuariosStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosRespostas",
                table: "UsuariosRespostas",
                columns: new[] { "QuizId", "QuestaoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioNivel",
                table: "UsuarioNivel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosRespostas_Questoes_QuestaoId",
                table: "UsuariosRespostas",
                column: "QuestaoId",
                principalTable: "Questoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosRespostas_Quizzes_QuizId",
                table: "UsuariosRespostas",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosRespostas_Usuarios_UsuarioId",
                table: "UsuariosRespostas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosStatus_UsuarioNivel_NivelId",
                table: "UsuariosStatus",
                column: "NivelId",
                principalTable: "UsuarioNivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosStatus_Usuarios_Id",
                table: "UsuariosStatus",
                column: "Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
