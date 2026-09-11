using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "QuestaoTipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Verdadeiro ou Falso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "QuestaoTipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Verdadeira ou Falso");
        }
    }
}
