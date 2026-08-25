using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class Atualiza3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Questoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "Questoes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
