using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaNiveis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PontosMax",
                table: "UsuarioNiveis",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PontosMin",
                table: "UsuarioNiveis",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PontosMax",
                table: "UsuarioNiveis");

            migrationBuilder.DropColumn(
                name: "PontosMin",
                table: "UsuarioNiveis");
        }
    }
}
