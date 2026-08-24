using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaModelosEContexto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                table: "UsuarioRespostas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStatus_UsuarioNiveis_NivelId",
                table: "UsuarioStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStatus_Usuarios_Id",
                table: "UsuarioStatus");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioRespostas_UsuarioId",
                table: "UsuarioRespostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioStatus",
                table: "UsuarioStatus");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "UsuarioRespostas");

            migrationBuilder.RenameTable(
                name: "UsuarioStatus",
                newName: "UsuarioStats");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioStatus_NivelId",
                table: "UsuarioStats",
                newName: "IX_UsuarioStats_NivelId");

            migrationBuilder.AddColumn<int>(
                name: "PontuacaoInicial",
                table: "UsuarioRespostas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioStats",
                table: "UsuarioStats",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStats_UsuarioNiveis_NivelId",
                table: "UsuarioStats",
                column: "NivelId",
                principalTable: "UsuarioNiveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStats_Usuarios_Id",
                table: "UsuarioStats",
                column: "Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStats_UsuarioNiveis_NivelId",
                table: "UsuarioStats");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioStats_Usuarios_Id",
                table: "UsuarioStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioStats",
                table: "UsuarioStats");

            migrationBuilder.DropColumn(
                name: "PontuacaoInicial",
                table: "UsuarioRespostas");

            migrationBuilder.RenameTable(
                name: "UsuarioStats",
                newName: "UsuarioStatus");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioStats_NivelId",
                table: "UsuarioStatus",
                newName: "IX_UsuarioStatus_NivelId");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "UsuarioRespostas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioStatus",
                table: "UsuarioStatus",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRespostas_UsuarioId",
                table: "UsuarioRespostas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRespostas_Usuarios_UsuarioId",
                table: "UsuarioRespostas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStatus_UsuarioNiveis_NivelId",
                table: "UsuarioStatus",
                column: "NivelId",
                principalTable: "UsuarioNiveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioStatus_Usuarios_Id",
                table: "UsuarioStatus",
                column: "Id",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
