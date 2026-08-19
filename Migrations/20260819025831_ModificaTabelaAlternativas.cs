using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class ModificaTabelaAlternativas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Perguntas_PerguntaId",
                table: "Alternativas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alternativas",
                table: "Alternativas");

            migrationBuilder.RenameTable(
                name: "Alternativas",
                newName: "PerguntasAlternativas");

            migrationBuilder.RenameColumn(
                name: "EhCorreta",
                table: "PerguntasAlternativas",
                newName: "IsCorreta");

            migrationBuilder.RenameIndex(
                name: "IX_Alternativas_PerguntaId",
                table: "PerguntasAlternativas",
                newName: "IX_PerguntasAlternativas_PerguntaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "PerguntaTemas",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerguntasAlternativas",
                table: "PerguntasAlternativas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerguntasAlternativas_Perguntas_PerguntaId",
                table: "PerguntasAlternativas",
                column: "PerguntaId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerguntasAlternativas_Perguntas_PerguntaId",
                table: "PerguntasAlternativas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerguntasAlternativas",
                table: "PerguntasAlternativas");

            migrationBuilder.RenameTable(
                name: "PerguntasAlternativas",
                newName: "Alternativas");

            migrationBuilder.RenameColumn(
                name: "IsCorreta",
                table: "Alternativas",
                newName: "EhCorreta");

            migrationBuilder.RenameIndex(
                name: "IX_PerguntasAlternativas_PerguntaId",
                table: "Alternativas",
                newName: "IX_Alternativas_PerguntaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "PerguntaTemas",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alternativas",
                table: "Alternativas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Perguntas_PerguntaId",
                table: "Alternativas",
                column: "PerguntaId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
