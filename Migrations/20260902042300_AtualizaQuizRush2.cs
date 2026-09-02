using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaQuizRush2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:Motivo Encerrado", "resposta_errada,tempo_esgotou")
                .Annotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso")
                .OldAnnotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso");

            migrationBuilder.AddColumn<int>(
                name: "MotivoEncerrado",
                table: "QuizzesRush",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotivoEncerrado",
                table: "QuizzesRush");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso")
                .OldAnnotation("Npgsql:Enum:Motivo Encerrado", "resposta_errada,tempo_esgotou")
                .OldAnnotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso");
        }
    }
}
