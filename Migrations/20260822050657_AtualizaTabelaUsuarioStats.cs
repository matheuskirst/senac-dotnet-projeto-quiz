using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaTabelaUsuarioStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                table: "UsuariosStatus");

            migrationBuilder.AlterColumn<int>(
                name: "TemaMaisAcertadoId",
                table: "UsuariosStatus",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                table: "UsuariosStatus",
                column: "TemaMaisAcertadoId",
                principalTable: "PerguntaTemas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                table: "UsuariosStatus");

            migrationBuilder.AlterColumn<int>(
                name: "TemaMaisAcertadoId",
                table: "UsuariosStatus",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosStatus_PerguntaTemas_TemaMaisAcertadoId",
                table: "UsuariosStatus",
                column: "TemaMaisAcertadoId",
                principalTable: "PerguntaTemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
