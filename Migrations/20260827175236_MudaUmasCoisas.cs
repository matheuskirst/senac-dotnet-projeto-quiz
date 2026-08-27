using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class MudaUmasCoisas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStats_Usuarios_Id",
                table: "UsuarioStats");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UsuarioStats",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Verdadeira",
                table: "Questoes",
                newName: "VerdadeiroFalso");

            migrationBuilder.RenameColumn(
                name: "Pontos",
                table: "QuestaoNiveis",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "Correta",
                table: "Alternativas",
                newName: "EhCorreta");

            migrationBuilder.AddColumn<int>(
                name: "QuestaoValor",
                table: "UsuarioRespostas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStats_Usuarios_UsuarioId",
                table: "UsuarioStats",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStats_Usuarios_UsuarioId",
                table: "UsuarioStats");

            migrationBuilder.DropColumn(
                name: "QuestaoValor",
                table: "UsuarioRespostas");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "UsuarioStats",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VerdadeiroFalso",
                table: "Questoes",
                newName: "Verdadeira");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "QuestaoNiveis",
                newName: "Pontos");

            migrationBuilder.RenameColumn(
                name: "EhCorreta",
                table: "Alternativas",
                newName: "Correta");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStats_Usuarios_Id",
                table: "UsuarioStats",
                column: "Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
