using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaConquistas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlternativaId",
                table: "UsuarioRespostas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "VerdadeiroFalso",
                table: "UsuarioRespostas",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxAcertosSeguidos",
                table: "QuizzesDiarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRespostas_AlternativaId",
                table: "UsuarioRespostas",
                column: "AlternativaId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Alternativas_AlternativaId",
                table: "UsuarioRespostas",
                column: "AlternativaId",
                principalTable: "Alternativas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Alternativas_AlternativaId",
                table: "UsuarioRespostas");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioRespostas_AlternativaId",
                table: "UsuarioRespostas");

            migrationBuilder.DropColumn(
                name: "AlternativaId",
                table: "UsuarioRespostas");

            migrationBuilder.DropColumn(
                name: "VerdadeiroFalso",
                table: "UsuarioRespostas");

            migrationBuilder.DropColumn(
                name: "MaxAcertosSeguidos",
                table: "QuizzesDiarios");
        }
    }
}
