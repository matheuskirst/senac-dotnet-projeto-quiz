using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class Atualiza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsConcluido",
                table: "Quizzes",
                newName: "FoiConcluido");

            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "Questoes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "QuestaoNiveis",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Questoes");

            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "QuestaoNiveis");

            migrationBuilder.RenameColumn(
                name: "FoiConcluido",
                table: "Quizzes",
                newName: "IsConcluido");
        }
    }
}
