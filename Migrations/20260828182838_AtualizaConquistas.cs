using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaConquistas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxAcertosConsecutivos",
                table: "UsuarioStats",
                newName: "MaxAcertosSeguidos");

            migrationBuilder.RenameColumn(
                name: "AtualAcertosConsecutivos",
                table: "UsuarioStats",
                newName: "AtualAcertosSeguidos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "QuestaoTemas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Meta",
                table: "Conquistas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TemaId",
                table: "Conquistas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Conquistas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UsuariosAcessos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataAcesso = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosAcessos", x => new { x.UsuarioId, x.DataAcesso });
                    table.ForeignKey(
                        name: "FK_UsuariosAcessos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTemasProgressos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    TemaId = table.Column<int>(type: "integer", nullable: false),
                    RespostasCorretas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTemasProgressos", x => new { x.UsuarioId, x.TemaId });
                    table.ForeignKey(
                        name: "FK_UsuarioTemasProgressos_QuestaoTemas_TemaId",
                        column: x => x.TemaId,
                        principalTable: "QuestaoTemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioTemasProgressos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conquistas_TemaId",
                table: "Conquistas",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioTemasProgressos_TemaId",
                table: "UsuarioTemasProgressos",
                column: "TemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conquistas_QuestaoTemas_TemaId",
                table: "Conquistas",
                column: "TemaId",
                principalTable: "QuestaoTemas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conquistas_QuestaoTemas_TemaId",
                table: "Conquistas");

            migrationBuilder.DropTable(
                name: "UsuariosAcessos");

            migrationBuilder.DropTable(
                name: "UsuarioTemasProgressos");

            migrationBuilder.DropIndex(
                name: "IX_Conquistas_TemaId",
                table: "Conquistas");

            migrationBuilder.DropColumn(
                name: "Meta",
                table: "Conquistas");

            migrationBuilder.DropColumn(
                name: "TemaId",
                table: "Conquistas");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Conquistas");

            migrationBuilder.RenameColumn(
                name: "MaxAcertosSeguidos",
                table: "UsuarioStats",
                newName: "MaxAcertosConsecutivos");

            migrationBuilder.RenameColumn(
                name: "AtualAcertosSeguidos",
                table: "UsuarioStats",
                newName: "AtualAcertosConsecutivos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "QuestaoTemas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
