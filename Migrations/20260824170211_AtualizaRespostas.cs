using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaRespostas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioRespostas",
                table: "UsuarioRespostas");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "UsuarioRespostas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioRespostas",
                table: "UsuarioRespostas",
                columns: new[] { "UsuarioId", "QuizId", "QuestaoId" });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRespostas_QuizId",
                table: "UsuarioRespostas",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                table: "UsuarioRespostas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                table: "UsuarioRespostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioRespostas",
                table: "UsuarioRespostas");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioRespostas_QuizId",
                table: "UsuarioRespostas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "UsuarioRespostas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioRespostas",
                table: "UsuarioRespostas",
                columns: new[] { "QuizId", "QuestaoId" });
        }
    }
}
