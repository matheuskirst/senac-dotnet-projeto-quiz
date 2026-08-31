using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaQuestoesTipos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questoes_QuestaoTipos_TipoId",
                table: "Questoes");

            migrationBuilder.DropTable(
                name: "QuestaoTipos");

            migrationBuilder.DropIndex(
                name: "IX_Questoes_TipoId",
                table: "Questoes");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Questoes");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Questoes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Questoes");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:Tipo", "alternativas,verdadeiro_ou_falso");

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Questoes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "QuestaoTipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoTipos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_TipoId",
                table: "Questoes",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questoes_QuestaoTipos_TipoId",
                table: "Questoes",
                column: "TipoId",
                principalTable: "QuestaoTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
